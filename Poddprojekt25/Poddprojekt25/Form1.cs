namespace Poddprojekt25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void visapoddFlöde_Click(object sender, EventArgs e)
        {
            //metod som returnerar en lista baserad på rss flödet, överför till poddlistan
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

        private void sparaPodd_Click(object sender, EventArgs e)
        {
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
    }
}
