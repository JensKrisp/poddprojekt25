using Models;
using Affärslogiklagret;
using System.Threading.Tasks;

namespace Poddprojekt25
{
    public partial class Form1 : Form
    {
        private IPodcastService PodcastService;
        private IAvsnittService AvsnittService;
        private IKategoriService KategoriService;


        public Form1(IPodcastService PodcastService, IAvsnittService AvsnittService, IKategoriService KategoriService)
        {
            this.PodcastService = PodcastService;
            this.AvsnittService = AvsnittService;
            this.KategoriService = KategoriService;
            InitializeComponent();
            this.Shown += Form1_Load;
        }

        private async void visapoddFlöde_Click(object sender, EventArgs e)
        {
            try
            {

                var enPodcast = await PodcastService.LäsPodcastFrånUrl(URL.Text);
                List<Avsnitt> allaAvsnitt = await AvsnittService.LäsInAllaAvsnitt(enPodcast);
                listaAvsnittBox.DisplayMember = "Titel";
                listaAvsnittBox.Items.Clear();
                foreach (Avsnitt avsnitt in allaAvsnitt)
                {
                    listaAvsnittBox.Items.Add(avsnitt);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kolla, det blev fel, alltihop " + ex.Message);

            }
        }


        private async void sparaPodd_Click(object sender, EventArgs e)
        {
            try
            {
                var enPodcast = await PodcastService.LäsPodcastFrånUrl(URL.Text);
                await PodcastService.SparaPodcastMedAvsnitt(enPodcast);

                listaPodcastMinaSidor.Items.Add(enPodcast);
                listaPodcastKategori.Items.Add(enPodcast);
                MessageBox.Show("Podcasten har sparats :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel när podcasten skulle sparas. " + ex.Message);
            }
            //lägg till vald podd i mina sparade poddar, beroende på hur vi tänker spara allt kan det bli att om vi sparar exakt alla poddar från rss flödet att vi lägger till en boolean eller nåt, annars spara db eller nåt
        }



        private void listaPoddarMinaSidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //väldigt liknande den andra listan där vi ska visa avsnitt från podd kanske blir exakt likadant
        }

        private async void raderapodd_Click(object sender, EventArgs e)
        {
            if (listaPodcastMinaSidor.SelectedItem == null)
            {
                return;
            }
            Podcast valdPodd = (Podcast)listaPodcastMinaSidor.SelectedItem;
            string meddelande = "Vill du verkligen ta bort " + valdPodd.Titel + ", den podcasten som du en gång höll så kärt?";
            string titel = "Du vet nog vad som gäller..";
            MessageBoxButtons knappar = MessageBoxButtons.YesNo;
            var meddelandeRuta = MessageBox.Show(meddelande, titel, knappar);
            if (meddelandeRuta == DialogResult.Yes)
                try
                {
                    listaPodcastMinaSidor.Items.Remove(valdPodd);
                    MessageBox.Show("Podcasten har tagits bort :(");
                    await PodcastService.RaderaPodcast(valdPodd.Id);
                   
                   
                }
                catch (Exception ex) { MessageBox.Show("Lägg märke till detta fel " + ex.Message); }


        }

        private async void publiceringsDatum_Click(object sender, EventArgs e)
        {
            var valdPodd = (Podcast)listaPodcastMinaSidor.SelectedItem;
            DateTime datum1 = tidigareDatum.Value.Date;
            DateTime datum2 = senareDatum.Value.Date;
            if (datum1 == null || datum2 == null || valdPodd == null)
            {
                MessageBox.Show("Vänligen fyll i båda datumen samt välj en podcast");
                return;
            }
            var filtreradeAvsnitt = await AvsnittService.HämtaAvsnittMellanDatum(datum1, datum2, valdPodd);
            listaAvsnittMinaSidor.DisplayMember = "titel";
            listaAvsnittMinaSidor.Items.Clear();
            foreach (Avsnitt avsnitt in filtreradeAvsnitt)
            {
                listaAvsnittMinaSidor.Items.Add(avsnitt);
            }
        }



        private async void visaKategorier_Click(object sender, EventArgs e)
        {
            var kategoriLista = await KategoriService.HämtaAllaKategorierAsync();
            listaKategorier.DisplayMember = "Namn";
            listaKategorier.Items.Clear();
            sorteraKategorierMinaSidor.DisplayMember = "Namn";
            sorteraKategorierMinaSidor.Items.Clear();
            foreach (Kategori kategori in kategoriLista)
            {
                listaKategorier.Items.Add(kategori);
                sorteraKategorierMinaSidor.Items.Add(kategori);
            }

        }

        private async void skapanyKategori_Click(object sender, EventArgs e)
        {
            String nyKategori = skapaKategoriText.Text;
            if (nyKategori == "")
            {
                MessageBox.Show("Skriv något i rutan ovanför för att skapa kategori");
                return;
            }

            {
                try
                {


                    await KategoriService.SkapaKategoriAsync(nyKategori);
                    MessageBox.Show("Kategorin har skapats!");
                    visaKategorier_Click(sender, e);

                }
                catch (Exception ex)
                { MessageBox.Show("Något gick fel när kategorin skulle skapas. " + ex.Message); }

                //kanske en ny messagebox? iallafall en metod som tar emot en string och lägger till som tillgänglig kategori, vi kommer nog behöva spara kategorier som sin egen grej.... 
            }
        }


        private void listaAvsnittMinaSidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valtAvsnitt = (Avsnitt)listaAvsnittMinaSidor.SelectedItem;
            beskrivningsBoxMinaSidor.Clear();
            beskrivningsBoxMinaSidor.AppendText(" Du har valt att lära dig mer om " + valtAvsnitt.Titel + " det är ett avsnitt som publicerades " + valtAvsnitt.Publiceringsdatum + " och handlar lite om " + valtAvsnitt.Beskrivning);
            //metod som tar emot avsnittsID eller nåt sånt och returnerar string med beskrivning
        }



        private async void sorteraKategorier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valdKategori = (Kategori)sorteraKategorierMinaSidor.SelectedItem;
            if (valdKategori == null)
            {
                return;
            }
            if (valdKategori.Id == "-1")
            {
                uppdateraPoddlistaMinaSidor_Click(sender, e);
                return;
            }


            List<Podcast> podcastsFörKategori = await KategoriService.HämtaPodcastsFörKategoriAsync(valdKategori.Id);
            listaPodcastMinaSidor.Items.Clear();
            listaPodcastMinaSidor.DisplayMember = "Titel";
            foreach (Podcast podcast in podcastsFörKategori)
            {
                listaPodcastMinaSidor.Items.Add(podcast);
            }


        }




        private void listaAvsnittBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valtAvsnitt = (Avsnitt)listaAvsnittBox.SelectedItem;
            avsnittBeskrivning.Clear();
            avsnittBeskrivning.AppendText(" Du har valt att lära dig mer om " + valtAvsnitt.Titel + " det är ett avsnitt som publicerades " + valtAvsnitt.Publiceringsdatum + " och handlar lite om " + valtAvsnitt.Beskrivning);
        }



        private async void uppdateraPoddlistaMinaSidor_Click(object sender, EventArgs e)
        {
            var poddlista = await PodcastService.HämtaAllaPodcast();
            var kategoriLista = await KategoriService.HämtaAllaKategorierAsync();
            listaPodcastMinaSidor.DisplayMember = "Titel";
            listaPodcastMinaSidor.Items.Clear();
            sorteraKategorierMinaSidor.DisplayMember = "Namn";
            sorteraKategorierMinaSidor.Items.Clear();
            foreach (Podcast podcast in poddlista)
            {
                listaPodcastMinaSidor.Items.Add(podcast);
            }
            foreach (Kategori kategori in kategoriLista)
            {
                sorteraKategorierMinaSidor.Items.Add(kategori);
            }
            sorteraKategorierMinaSidor.Items.Add(new Kategori { Id = "-1", Namn = "Alla" });
        }

        private async void listaPodcastMinaSidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast valdPodd = (Podcast)listaPodcastMinaSidor.SelectedItem;
            if (valdPodd == null)
            {
                return;
            }
            try
            {

                var avsnittLista = await AvsnittService.HämtaAvsnittFörPodcast(valdPodd.Id);
                listaAvsnittMinaSidor.DisplayMember = "Titel";
                listaAvsnittMinaSidor.Items.Clear();
                foreach (Avsnitt avsnitt in avsnittLista)
                {
                    listaAvsnittMinaSidor.Items.Add(avsnitt);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            VisaPodcastKategori_Click(sender, e);
            visaKategorier_Click(sender, e);
        }

        private async void bytNamnKnapp_Click(object sender, EventArgs e)
        {
            Podcast valdPodd = (Podcast)listaPodcastMinaSidor.SelectedItem;
            String nyttNamn = nyttNamnRuta.Text;
            if (string.IsNullOrWhiteSpace(nyttNamn) || valdPodd == null)
            {
                return;
            }
            try
            {
                await PodcastService.UppdateraPodcastTitel(valdPodd.Id, nyttNamn);
                uppdateraPoddlistaMinaSidor_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void redigeraKategoriKnapp_Click(object sender, EventArgs e)
        {
            String nyttKategoriNamn = redigeraKategori.Text;
            Kategori valdKategori = (Kategori)listaKategorier.SelectedItem;
            if (string.IsNullOrWhiteSpace(nyttKategoriNamn) || valdKategori == null)
            {
                return;
            }
            try
            {
                KategoriService.ÄndraNamnPåKategoriAsync(valdKategori.Id, nyttKategoriNamn);
                visaKategorier_Click(sender, e);
                MessageBox.Show("Kategorin har ändrats.");


            }
            catch (Exception ex) { MessageBox.Show("Något gick fel när kategorin skulle ändras. " + ex.Message); }
        }

        private async void VisaPodcastKategori_Click(object sender, EventArgs e)
        {
            var poddlista = await PodcastService.HämtaAllaPodcast();
            listaPodcastKategori.DisplayMember = "Titel";
            listaPodcastKategori.Items.Clear();
            foreach (Podcast podcast in poddlista)
            {
                listaPodcastKategori.Items.Add(podcast);
            }
        }

        private async void listaPodcastKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast valdPodd = (Podcast)listaPodcastKategori.SelectedItem;
            if (valdPodd == null)
            {
                return;
            }
            List<Kategori> kategorierFörPodcast = await KategoriService.HämtaKategorierFörPodcastAsync(valdPodd.Id);
            List<Kategori> samtligaKategorier = await KategoriService.HämtaAllaKategorierAsync();
            KategorierFörPodcast.DisplayMember = "Namn";
            KategorierFörPodcast.Items.Clear();
            allaKategorier.DisplayMember = "Namn";
            allaKategorier.Items.Clear();
            foreach (Kategori kategori in kategorierFörPodcast)
            {
                KategorierFörPodcast.Items.Add(kategori);
            }
            foreach (Kategori kategori in samtligaKategorier)
            {
                allaKategorier.Items.Add(kategori);
            }




        }

        private async void taBortKategori_Click(object sender, EventArgs e)
        {

            var valdKategori = (Kategori)listaKategorier.SelectedItem;
            if (valdKategori == null)
            {
                return;
            }
            string meddelande = "Vill du verkligen ta bort " + valdKategori.Namn + ", kategorin som en gång innehöll alla dina favoritpodcast?";
            string titel = "Du vet nog vad som gäller..";
            MessageBoxButtons knappar = MessageBoxButtons.YesNo;
            var meddelandeRuta = MessageBox.Show(meddelande, titel, knappar);
            if (meddelandeRuta == DialogResult.Yes)
                try
                {
                    listaKategorier.Items.Remove(valdKategori);
                    sorteraKategorierMinaSidor.Items.Remove(valdKategori);
                    await KategoriService.RaderaKategoriAsync(valdKategori.Id);
                    MessageBox.Show("Kategorin har tagits bort. ");

                }
                catch (Exception ex) { MessageBox.Show("Lägg märke till detta fel " + ex.Message); }

        }

        private async void taBortKategoriFrånPodcast_Click(object sender, EventArgs e)
        {
            var valdPodd = (Podcast)listaPodcastKategori.SelectedItem;
            var valdKategori = (Kategori)KategorierFörPodcast.SelectedItem;
            if (valdPodd == null || valdKategori == null)
            {
                MessageBox.Show("Vänligen markera en podcast och välj en kategori");
                return;
            }
            try
            {
                KategorierFörPodcast.Items.Remove(valdKategori);
                allaKategorier.Items.Add(valdKategori);
                await KategoriService.TaBortPodcastFrånKategoriAsync(valdKategori.Id, valdPodd.Id);
                MessageBox.Show("Kategorin har tagits bort från podcasten.");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private async void läggTillKategoriIPodcast_Click(object sender, EventArgs e)
        {
            var valdPodd = (Podcast)listaPodcastKategori.SelectedItem;
            var valdKategori = (Kategori)allaKategorier.SelectedItem;
            if (valdPodd == null || valdKategori == null)
            {
                MessageBox.Show("Vänligen välj en podcast samt en kategori");
                return;
            }
            try
            {
                await KategoriService.LäggTillPodcastIKategoriAsync(valdKategori.Id, valdPodd.Id);
                listaPodcastKategori_SelectedIndexChanged(sender, e);
                MessageBox.Show("Kategorin har lagts till podcasten.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            uppdateraPoddlistaMinaSidor_Click(sender, e);
            visaKategorier_Click(sender, e);
            VisaPodcastKategori_Click(sender, e);
            uppdateraPoddlistaMinaSidor_Click(sender, e);
        }



    }
}
