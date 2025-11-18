using Models;
using Affärslogiklagret;

namespace Poddprojekt25
{
    public partial class Form1 : Form
    { private PodcastAppService PodcastAppService;
        private List<Avsnitt> allaAvsnitt;

        public Form1(PodcastAppService PodcastAppService)
        {
            this.PodcastAppService = PodcastAppService;
            InitializeComponent();
        }

        private async void visapoddFlöde_Click(object sender, EventArgs e)
        {
            try { var enPodcast = await PodcastAppService.LäsPodcastFrånUrl(URL.Text);
                allaAvsnitt = await PodcastAppService.LäsInAllaAvsnitt(enPodcast);
                listaAvsnittBox.DisplayMember = "Titel";
                listaAvsnitt.Items.Clear();
                foreach (Avsnitt avsnitt in allaAvsnitt)
                {
                    listaAvsnittBox.Items.Add(avsnitt);
                }
                
            }catch(Exception ex) {
                MessageBox.Show("kolla, det blev fel, alltihop");

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
                var enPodcast = await PodcastAppService.LäsPodcastFrånUrl(URL.Text);
                await PodcastAppService.SparaPodcastMedAvsnitt(enPodcast);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            //lägg till vald podd i mina sparade poddar, beroende på hur vi tänker spara allt kan det bli att om vi sparar exakt alla poddar från rss flödet att vi lägger till en boolean eller nåt, annars spara db eller nåt
        }

        private void listaAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kräver metod som returnerar beskrivning baserat på avsnittsID alternativt poddID och sen GUID beroende på hur det blir
        }

        private void listaPoddarMinaSidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //väldigt liknande den andra listan där vi ska visa avsnitt från podd kanske blir exakt likadant
        }

        private void raderapodd_Click(object sender, EventArgs e)
        {
            string meddelande = "vill du verkligen ta bort podden,den podd som du en gång höll så kärt?";
            string titel = "du vet nog vad som gäller..";
            MessageBoxButtons knappar = MessageBoxButtons.YesNo;
            MessageBox.Show(meddelande, titel, knappar);
            // kör en metod i arbetslagret som kör igång en sån här messagebox, började skriva för det känns typ som presentation så rutan finns
            // måste importera windows.forms för att få med messagebox :)
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
    }
}
