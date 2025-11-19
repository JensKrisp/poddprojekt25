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
        }

        private async void visapoddFlöde_Click(object sender, EventArgs e)
        {
            try
            {
                List<Avsnitt> allaAvsnitt;
                var enPodcast = await PodcastService.LäsPodcastFrånUrl(URL.Text);
                allaAvsnitt = await AvsnittService.LäsInAllaAvsnitt(enPodcast);
                listaAvsnittBox.DisplayMember = "Titel";
                listaAvsnittBox.Items.Clear();
                foreach (Avsnitt avsnitt in allaAvsnitt)
                {
                    listaAvsnittBox.Items.Add(avsnitt);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("kolla, det blev fel, alltihop" + ex.Message);

            }
            //metod som returnerar en lista poddar baserad på rss flödet, överför till poddlistan
            //bör också uppdatera kategorierna i sorteraKategorier
        }

        private void URLOchMinaSparade_TextChanged(object sender, EventArgs e)
        {
            //kod som returnerar ett projekt baserat på URL kanske? blir kanske lättast om den också returnerar en lista så slipper vi göra en ny metod
        }

        private void listaPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uppdatera avsnittslista när podd väljs behöver metod som returnerar lista efter avsnitt kopplade till poddID
        }

        private async void sparaPodd_Click(object sender, EventArgs e)
        {
            try
            {
                var enPodcast = await PodcastService.LäsPodcastFrånUrl(URL.Text);
                await PodcastService.SparaPodcastMedAvsnitt(enPodcast);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel när podden skulle sparas. " + ex.Message);
            }
            //lägg till vald podd i mina sparade poddar, beroende på hur vi tänker spara allt kan det bli att om vi sparar exakt alla poddar från rss flödet att vi lägger till en boolean eller nåt, annars spara db eller nåt
        }

        private void listaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string meddelande = "vill du verkligen ta bort " + valdPodd.Titel + ",den podd som du en gång höll så kärt?";
            string titel = "du vet nog vad som gäller..";
            MessageBoxButtons knappar = MessageBoxButtons.YesNo;
            var meddelandeRuta = MessageBox.Show(meddelande, titel, knappar);
            if (meddelandeRuta == DialogResult.Yes)
                try
                {
                    await PodcastService.RaderaPodcast(valdPodd.Id);
                    uppdateraPoddlistaMinaSidor_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("lägg märke till detta fel" + ex.Message); }


        }

        private void publiceringsDatum_Click(object sender, EventArgs e)
        {
            DateTime datum1 = tidigareDatum.Value.Date;
            DateTime datum2 = senareDatum.Value.Date;
            //en metod i arbetslagret som tar jämför dessa två datum och uppdaterar avsnittslistan
        }

        private void sorteraKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //behöver en metod som tar emot en kategori och uppdaterar poddlistan med denna
        }

        private void visaKategorier_Click(object sender, EventArgs e)
        {
            //metod som uppdaterar listaKategorier med alla kategorier som finns, behöver inte nödvändigtvis sitta på en sån här knapp
        }

        private void skapanyKategori_Click(object sender, EventArgs e)
        {
            if (skapaKategoriText.Text == "")
            {
                MessageBox.Show("Skriv något i rutan ovanför för att skapa kategori");
                return;
            }

            //kanske en ny messagebox? iallafall en metod som tar emot en string och lägger till som tillgänglig kategori, vi kommer nog behöva spara kategorier som sin egen grej.... 
        }

        private void redigeraKategori_Click(object sender, EventArgs e)
        {
            // en metod som tar emot en string och kategoriID och uppdaterar kategorin i databasen
        }

        private void raderaKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lite liknande som radera podd, en messagebox med ja eller nej, sedan en metod som tar bort kategorin ur kategorilistan, frågor om hur det blir med de poddar som förlorar sin kategori :(
        }

        private void listaPoddarKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metod tar emot en string som uppdaterar poddlistan baserat på vald kategori
        }

        private void listaAvsnittMinaSidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valtAvsnitt = (Avsnitt)listaAvsnittMinaSidor.SelectedItem;
            avsnittBeskrivning.Clear();
            avsnittBeskrivning.AppendText(" du har valt att lära dig mer om " + valtAvsnitt.Titel + " det är ett avsnitt som publicerades " + valtAvsnitt.Publiceringsdatum + " och handlar lite om " + valtAvsnitt.Beskrivning);
            //metod som tar emot avsnittsID eller nåt sånt och returnerar string med beskrivning
        }

        private void avsnittBeskrivningMinaSidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void sorteraKategorier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metod som tar emot en kategori och uppdaterar poddlistan i mina sparade poddar
        }

        private void listaKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //funderar vi istället använder denna lista för kategorihantering, metoderna i affärslogikslagret är dock desamma
        }



        private void listaAvsnittBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valtAvsnitt = (Avsnitt)listaAvsnittBox.SelectedItem;
            avsnittBeskrivning.Clear();
            avsnittBeskrivning.AppendText(" du har valt att lära dig mer om " + valtAvsnitt.Titel + " det är ett avsnitt som publicerades " + valtAvsnitt.Publiceringsdatum + " och handlar lite om " + valtAvsnitt.Beskrivning);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void uppdateraPoddlistaMinaSidor_Click(object sender, EventArgs e)
        {
            var poddlista = await PodcastService.HämtaAllaPodcast();
            listaPodcastMinaSidor.DisplayMember = "Titel";
            listaPodcastMinaSidor.Items.Clear();
            foreach (Podcast podcast in poddlista)
            {
                listaPodcastMinaSidor.Items.Add(podcast);
            }
        }

        private async void listaPodcastMinaSidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Podcast valdPodd = (Podcast)listaPodcastMinaSidor.SelectedItem;
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

        }
    }
}
