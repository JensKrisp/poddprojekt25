namespace Poddprojekt25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uppdateraPoddFlöde = new Button();
            URL = new TextBox();
            sparaPodd = new Button();
            raderapodd = new Button();
            skapanyKategori = new Button();
            poddTabbar = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            label11 = new Label();
            label5 = new Label();
            listaAvsnittBox = new ListBox();
            avsnittBeskrivning = new RichTextBox();
            tabPage2 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label7 = new Label();
            beskrivningsBoxMinaSidor = new RichTextBox();
            uppdateraPoddlistaMinaSidor = new Button();
            label6 = new Label();
            label4 = new Label();
            listaAvsnittMinaSidor = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            publiceringsDatum = new Button();
            bytNamnKnapp = new Button();
            tidigareDatum = new DateTimePicker();
            nyttNamnRuta = new TextBox();
            senareDatum = new DateTimePicker();
            listaPodcastMinaSidor = new ListBox();
            sorteraKategorierMinaSidor = new ComboBox();
            tabPage3 = new TabPage();
            label18 = new Label();
            label16 = new Label();
            label17 = new Label();
            label15 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            taBortKategori = new Button();
            VisaPodcastKategori = new Button();
            listaPodcastKategori = new ListBox();
            listaKategorier = new ListBox();
            TaBortKategoriFrånPodcast = new Button();
            LäggTillPodcastIKategori = new Button();
            KategorierFörPodcast = new ComboBox();
            allaKategorier = new ComboBox();
            redigeraKategoriKnapp = new Button();
            redigeraKategori = new TextBox();
            skapaKategoriText = new TextBox();
            visaKategorier = new Button();
            poddTabbar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // uppdateraPoddFlöde
            // 
            uppdateraPoddFlöde.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uppdateraPoddFlöde.Location = new Point(448, 99);
            uppdateraPoddFlöde.Margin = new Padding(4);
            uppdateraPoddFlöde.Name = "uppdateraPoddFlöde";
            uppdateraPoddFlöde.Size = new Size(148, 36);
            uppdateraPoddFlöde.TabIndex = 1;
            uppdateraPoddFlöde.Text = "Visa podcast\r\n";
            uppdateraPoddFlöde.UseVisualStyleBackColor = true;
            uppdateraPoddFlöde.Click += visapoddFlöde_Click;
            // 
            // URL
            // 
            URL.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            URL.Location = new Point(62, 102);
            URL.Margin = new Padding(4);
            URL.Name = "URL";
            URL.Size = new Size(330, 29);
            URL.TabIndex = 4;
           
            // 
            // sparaPodd
            // 
            sparaPodd.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sparaPodd.Location = new Point(255, 565);
            sparaPodd.Margin = new Padding(4);
            sparaPodd.Name = "sparaPodd";
            sparaPodd.Size = new Size(155, 36);
            sparaPodd.TabIndex = 5;
            sparaPodd.Text = "Spara podcast\r\n";
            sparaPodd.UseVisualStyleBackColor = true;
            sparaPodd.Click += sparaPodd_Click;
            // 
            // raderapodd
            // 
            raderapodd.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            raderapodd.Location = new Point(1120, 272);
            raderapodd.Margin = new Padding(4);
            raderapodd.Name = "raderapodd";
            raderapodd.Size = new Size(168, 36);
            raderapodd.TabIndex = 8;
            raderapodd.Text = "Radera podcast\r\n";
            raderapodd.UseVisualStyleBackColor = true;
            raderapodd.Click += raderapodd_Click;
            // 
            // skapanyKategori
            // 
            skapanyKategori.Font = new Font("Cambria", 9F);
            skapanyKategori.Location = new Point(1008, 184);
            skapanyKategori.Margin = new Padding(4);
            skapanyKategori.Name = "skapanyKategori";
            skapanyKategori.Size = new Size(104, 36);
            skapanyKategori.TabIndex = 10;
            skapanyKategori.Text = "Spara";
            skapanyKategori.UseVisualStyleBackColor = true;
            skapanyKategori.Click += skapanyKategori_Click;
            // 
            // poddTabbar
            // 
            poddTabbar.Controls.Add(tabPage1);
            poddTabbar.Controls.Add(tabPage2);
            poddTabbar.Controls.Add(tabPage3);
            poddTabbar.Location = new Point(2, 2);
            poddTabbar.Margin = new Padding(4);
            poddTabbar.Name = "poddTabbar";
            poddTabbar.SelectedIndex = 0;
            poddTabbar.Size = new Size(1344, 820);
            poddTabbar.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(listaAvsnittBox);
            tabPage1.Controls.Add(avsnittBeskrivning);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(sparaPodd);
            tabPage1.Controls.Add(uppdateraPoddFlöde);
            tabPage1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1336, 782);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Startsida";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label12.Location = new Point(483, 216);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(133, 26);
            label12.TabIndex = 18;
            label12.Text = "Beskrivning";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label11.Location = new Point(61, 216);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 26);
            label11.TabIndex = 17;
            label11.Text = "Avsnitt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 49);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(605, 26);
            label5.TabIndex = 16;
            label5.Text = "Klistra in en URL-adress för att lägga till en podcast i listan";
            // 
            // listaAvsnittBox
            // 
            listaAvsnittBox.FormattingEnabled = true;
            listaAvsnittBox.Location = new Point(61, 262);
            listaAvsnittBox.Margin = new Padding(4);
            listaAvsnittBox.Name = "listaAvsnittBox";
            listaAvsnittBox.Size = new Size(349, 256);
            listaAvsnittBox.TabIndex = 15;
            listaAvsnittBox.SelectedIndexChanged += listaAvsnittBox_SelectedIndexChanged;
            // 
            // avsnittBeskrivning
            // 
            avsnittBeskrivning.Location = new Point(483, 262);
            avsnittBeskrivning.Margin = new Padding(4);
            avsnittBeskrivning.Name = "avsnittBeskrivning";
            avsnittBeskrivning.Size = new Size(571, 256);
            avsnittBeskrivning.TabIndex = 10;
            avsnittBeskrivning.Text = "";
           
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(beskrivningsBoxMinaSidor);
            tabPage2.Controls.Add(uppdateraPoddlistaMinaSidor);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(listaAvsnittMinaSidor);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(publiceringsDatum);
            tabPage2.Controls.Add(bytNamnKnapp);
            tabPage2.Controls.Add(raderapodd);
            tabPage2.Controls.Add(tidigareDatum);
            tabPage2.Controls.Add(nyttNamnRuta);
            tabPage2.Controls.Add(senareDatum);
            tabPage2.Controls.Add(listaPodcastMinaSidor);
            tabPage2.Controls.Add(sorteraKategorierMinaSidor);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1336, 782);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sparade podcasts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(61, 310);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(477, 26);
            label14.TabIndex = 31;
            label14.Text = "Markera ett avsnitt för att se mer information\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(62, 58);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(383, 26);
            label13.TabIndex = 30;
            label13.Text = "Markera en podcast för att se avsnitt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label7.Location = new Point(179, 651);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 26);
            label7.TabIndex = 29;
            label7.Text = "till";
            // 
            // beskrivningsBoxMinaSidor
            // 
            beskrivningsBoxMinaSidor.Location = new Point(592, 359);
            beskrivningsBoxMinaSidor.Margin = new Padding(4);
            beskrivningsBoxMinaSidor.Name = "beskrivningsBoxMinaSidor";
            beskrivningsBoxMinaSidor.Size = new Size(672, 259);
            beskrivningsBoxMinaSidor.TabIndex = 21;
            beskrivningsBoxMinaSidor.Text = "";
        
            // 
            // uppdateraPoddlistaMinaSidor
            // 
            uppdateraPoddlistaMinaSidor.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uppdateraPoddlistaMinaSidor.Location = new Point(555, 24);
            uppdateraPoddlistaMinaSidor.Margin = new Padding(4);
            uppdateraPoddlistaMinaSidor.Name = "uppdateraPoddlistaMinaSidor";
            uppdateraPoddlistaMinaSidor.Size = new Size(159, 36);
            uppdateraPoddlistaMinaSidor.TabIndex = 17;
            uppdateraPoddlistaMinaSidor.Text = "Visa podcasts";
            uppdateraPoddlistaMinaSidor.UseVisualStyleBackColor = true;
            uppdateraPoddlistaMinaSidor.Visible = false;
            uppdateraPoddlistaMinaSidor.Click += uppdateraPoddlistaMinaSidor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label6.Location = new Point(179, 610);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 26);
            label6.TabIndex = 28;
            label6.Text = "från";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label4.Location = new Point(91, 564);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(395, 26);
            label4.TabIndex = 27;
            label4.Text = "Sortera podcasts efter datumintervall";
            // 
            // listaAvsnittMinaSidor
            // 
            listaAvsnittMinaSidor.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaAvsnittMinaSidor.FormattingEnabled = true;
            listaAvsnittMinaSidor.Location = new Point(62, 359);
            listaAvsnittMinaSidor.Margin = new Padding(4);
            listaAvsnittMinaSidor.Name = "listaAvsnittMinaSidor";
            listaAvsnittMinaSidor.Size = new Size(476, 151);
            listaAvsnittMinaSidor.TabIndex = 20;
            listaAvsnittMinaSidor.SelectedIndexChanged += listaAvsnittMinaSidor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label3.Location = new Point(509, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(327, 26);
            label3.TabIndex = 26;
            label3.Text = "Sortera podcasts efter kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(889, 232);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(399, 26);
            label2.TabIndex = 25;
            label2.Text = "Markera en podcast för att radera den";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label1.Location = new Point(878, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 26);
            label1.TabIndex = 24;
            label1.Text = "Markera en podcast för att ändra namn";
            // 
            // publiceringsDatum
            // 
            publiceringsDatum.Font = new Font("Cambria", 9F);
            publiceringsDatum.Location = new Point(272, 694);
            publiceringsDatum.Margin = new Padding(4);
            publiceringsDatum.Name = "publiceringsDatum";
            publiceringsDatum.Size = new Size(212, 36);
            publiceringsDatum.TabIndex = 13;
            publiceringsDatum.Text = "Sök publiceringsdatum";
            publiceringsDatum.UseVisualStyleBackColor = true;
            publiceringsDatum.Click += publiceringsDatum_Click;
            // 
            // bytNamnKnapp
            // 
            bytNamnKnapp.Font = new Font("Cambria", 9F);
            bytNamnKnapp.Location = new Point(1182, 151);
            bytNamnKnapp.Margin = new Padding(4);
            bytNamnKnapp.Name = "bytNamnKnapp";
            bytNamnKnapp.Size = new Size(106, 36);
            bytNamnKnapp.TabIndex = 23;
            bytNamnKnapp.Text = "Ändra";
            bytNamnKnapp.UseVisualStyleBackColor = true;
            bytNamnKnapp.Click += bytNamnKnapp_Click;
            // 
            // tidigareDatum
            // 
            tidigareDatum.Font = new Font("Cambria", 9F);
            tidigareDatum.Location = new Point(254, 611);
            tidigareDatum.Margin = new Padding(4);
            tidigareDatum.Name = "tidigareDatum";
            tidigareDatum.Size = new Size(232, 29);
            tidigareDatum.TabIndex = 11;
            // 
            // nyttNamnRuta
            // 
            nyttNamnRuta.Font = new Font("Cambria", 9F);
            nyttNamnRuta.Location = new Point(978, 151);
            nyttNamnRuta.Margin = new Padding(4);
            nyttNamnRuta.Name = "nyttNamnRuta";
            nyttNamnRuta.Size = new Size(169, 29);
            nyttNamnRuta.TabIndex = 22;
            // 
            // senareDatum
            // 
            senareDatum.Font = new Font("Cambria", 9F);
            senareDatum.Location = new Point(254, 648);
            senareDatum.Margin = new Padding(4);
            senareDatum.Name = "senareDatum";
            senareDatum.Size = new Size(232, 29);
            senareDatum.TabIndex = 12;
            
            // 
            // listaPodcastMinaSidor
            // 
            listaPodcastMinaSidor.Font = new Font("Cambria", 9F);
            listaPodcastMinaSidor.FormattingEnabled = true;
            listaPodcastMinaSidor.Location = new Point(62, 108);
            listaPodcastMinaSidor.Margin = new Padding(4);
            listaPodcastMinaSidor.Name = "listaPodcastMinaSidor";
            listaPodcastMinaSidor.Size = new Size(424, 151);
            listaPodcastMinaSidor.TabIndex = 19;
            listaPodcastMinaSidor.SelectedIndexChanged += listaPodcastMinaSidor_SelectedIndexChanged;
            // 
            // sorteraKategorierMinaSidor
            // 
            sorteraKategorierMinaSidor.Font = new Font("Cambria", 9F);
            sorteraKategorierMinaSidor.FormattingEnabled = true;
            sorteraKategorierMinaSidor.Location = new Point(648, 148);
            sorteraKategorierMinaSidor.Margin = new Padding(4);
            sorteraKategorierMinaSidor.Name = "sorteraKategorierMinaSidor";
            sorteraKategorierMinaSidor.Size = new Size(188, 29);
            sorteraKategorierMinaSidor.TabIndex = 18;
            sorteraKategorierMinaSidor.SelectedIndexChanged += sorteraKategorier2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(taBortKategori);
            tabPage3.Controls.Add(VisaPodcastKategori);
            tabPage3.Controls.Add(listaPodcastKategori);
            tabPage3.Controls.Add(listaKategorier);
            tabPage3.Controls.Add(TaBortKategoriFrånPodcast);
            tabPage3.Controls.Add(LäggTillPodcastIKategori);
            tabPage3.Controls.Add(KategorierFörPodcast);
            tabPage3.Controls.Add(allaKategorier);
            tabPage3.Controls.Add(redigeraKategoriKnapp);
            tabPage3.Controls.Add(redigeraKategori);
            tabPage3.Controls.Add(skapaKategoriText);
            tabPage3.Controls.Add(visaKategorier);
            tabPage3.Controls.Add(skapanyKategori);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1336, 782);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kategorier";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label18.Location = new Point(622, 32);
            label18.Name = "label18";
            label18.Size = new Size(176, 26);
            label18.TabIndex = 36;
            label18.Text = "Mina kategorier";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label16.Location = new Point(55, 32);
            label16.Name = "label16";
            label16.Size = new Size(91, 26);
            label16.TabIndex = 35;
            label16.Text = "Podcast";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(55, 311);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(455, 52);
            label17.TabIndex = 34;
            label17.Text = "Markera en podcast och välj en kategori du \r\n                                                   vill lägga till den i";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(55, 511);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(455, 52);
            label15.TabIndex = 32;
            label15.Text = "Markera en podcast och välj en kategori du \r\n                                               vill ta bort ifrån den";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(879, 338);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(390, 26);
            label10.TabIndex = 31;
            label10.Text = "Markera en kategori och ändra namn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1008, 92);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(193, 26);
            label9.TabIndex = 30;
            label9.Text = "Skapa ny kategori";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(862, 538);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(406, 26);
            label8.TabIndex = 29;
            label8.Text = "Markera en kategori för att radera den";
            // 
            // taBortKategori
            // 
            taBortKategori.Font = new Font("Cambria", 9F);
            taBortKategori.Location = new Point(1165, 580);
            taBortKategori.Margin = new Padding(4);
            taBortKategori.Name = "taBortKategori";
            taBortKategori.Size = new Size(104, 36);
            taBortKategori.TabIndex = 28;
            taBortKategori.Text = "Radera";
            taBortKategori.UseVisualStyleBackColor = true;
            taBortKategori.Click += taBortKategori_Click;
            // 
            // VisaPodcastKategori
            // 
            VisaPodcastKategori.Font = new Font("Cambria", 9F);
            VisaPodcastKategori.Location = new Point(362, 8);
            VisaPodcastKategori.Margin = new Padding(4);
            VisaPodcastKategori.Name = "VisaPodcastKategori";
            VisaPodcastKategori.Size = new Size(136, 36);
            VisaPodcastKategori.TabIndex = 27;
            VisaPodcastKategori.Text = "Visa podcast";
            VisaPodcastKategori.UseVisualStyleBackColor = true;
            VisaPodcastKategori.Visible = false;
            VisaPodcastKategori.Click += VisaPodcastKategori_Click;
            // 
            // listaPodcastKategori
            // 
            listaPodcastKategori.Font = new Font("Cambria", 9F);
            listaPodcastKategori.FormattingEnabled = true;
            listaPodcastKategori.Location = new Point(55, 75);
            listaPodcastKategori.Margin = new Padding(4);
            listaPodcastKategori.Name = "listaPodcastKategori";
            listaPodcastKategori.Size = new Size(443, 151);
            listaPodcastKategori.TabIndex = 26;
            listaPodcastKategori.SelectedIndexChanged += listaPodcastKategori_SelectedIndexChanged;
            // 
            // listaKategorier
            // 
            listaKategorier.Font = new Font("Cambria", 9F);
            listaKategorier.FormattingEnabled = true;
            listaKategorier.Location = new Point(622, 75);
            listaKategorier.Margin = new Padding(4);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(333, 151);
            listaKategorier.TabIndex = 25;
            // 
            // TaBortKategoriFrånPodcast
            // 
            TaBortKategoriFrånPodcast.Font = new Font("Cambria", 9F);
            TaBortKategoriFrånPodcast.Location = new Point(392, 632);
            TaBortKategoriFrånPodcast.Margin = new Padding(4);
            TaBortKategoriFrånPodcast.Name = "TaBortKategoriFrånPodcast";
            TaBortKategoriFrånPodcast.Size = new Size(118, 36);
            TaBortKategoriFrånPodcast.TabIndex = 24;
            TaBortKategoriFrånPodcast.Text = "Ta bort";
            TaBortKategoriFrånPodcast.UseVisualStyleBackColor = true;
            TaBortKategoriFrånPodcast.Click += taBortKategoriFrånPodcast_Click;
            // 
            // LäggTillPodcastIKategori
            // 
            LäggTillPodcastIKategori.Font = new Font("Cambria", 9F);
            LäggTillPodcastIKategori.Location = new Point(378, 432);
            LäggTillPodcastIKategori.Margin = new Padding(4);
            LäggTillPodcastIKategori.Name = "LäggTillPodcastIKategori";
            LäggTillPodcastIKategori.Size = new Size(118, 36);
            LäggTillPodcastIKategori.TabIndex = 23;
            LäggTillPodcastIKategori.Text = "Bekräfta";
            LäggTillPodcastIKategori.UseVisualStyleBackColor = true;
            LäggTillPodcastIKategori.Click += läggTillKategoriIPodcast_Click;
            // 
            // KategorierFörPodcast
            // 
            KategorierFörPodcast.Font = new Font("Cambria", 9F);
            KategorierFörPodcast.FormattingEnabled = true;
            KategorierFörPodcast.Location = new Point(262, 585);
            KategorierFörPodcast.Margin = new Padding(4);
            KategorierFörPodcast.Name = "KategorierFörPodcast";
            KategorierFörPodcast.Size = new Size(248, 29);
            KategorierFörPodcast.TabIndex = 22;
            // 
            // allaKategorier
            // 
            allaKategorier.Font = new Font("Cambria", 9F);
            allaKategorier.FormattingEnabled = true;
            allaKategorier.Location = new Point(262, 386);
            allaKategorier.Margin = new Padding(4);
            allaKategorier.Name = "allaKategorier";
            allaKategorier.Size = new Size(233, 29);
            allaKategorier.TabIndex = 21;
           
            // 
            // redigeraKategoriKnapp
            // 
            redigeraKategoriKnapp.Font = new Font("Cambria", 9F);
            redigeraKategoriKnapp.Location = new Point(1151, 432);
            redigeraKategoriKnapp.Margin = new Padding(4);
            redigeraKategoriKnapp.Name = "redigeraKategoriKnapp";
            redigeraKategoriKnapp.Size = new Size(118, 36);
            redigeraKategoriKnapp.TabIndex = 20;
            redigeraKategoriKnapp.Text = "Ändra namn";
            redigeraKategoriKnapp.UseVisualStyleBackColor = true;
            redigeraKategoriKnapp.Click += redigeraKategoriKnapp_Click;
            // 
            // redigeraKategori
            // 
            redigeraKategori.Font = new Font("Cambria", 9F);
            redigeraKategori.Location = new Point(1008, 386);
            redigeraKategori.Margin = new Padding(4);
            redigeraKategori.Name = "redigeraKategori";
            redigeraKategori.Size = new Size(262, 29);
            redigeraKategori.TabIndex = 19;
            // 
            // skapaKategoriText
            // 
            skapaKategoriText.Font = new Font("Cambria", 9F);
            skapaKategoriText.Location = new Point(1008, 135);
            skapaKategoriText.Margin = new Padding(4);
            skapaKategoriText.Name = "skapaKategoriText";
            skapaKategoriText.Size = new Size(262, 29);
            skapaKategoriText.TabIndex = 18;
            // 
            // visaKategorier
            // 
            visaKategorier.Font = new Font("Cambria", 9F);
            visaKategorier.Location = new Point(802, 8);
            visaKategorier.Margin = new Padding(4);
            visaKategorier.Name = "visaKategorier";
            visaKategorier.Size = new Size(154, 36);
            visaKategorier.TabIndex = 15;
            visaKategorier.Text = "Visa kategorier";
            visaKategorier.UseVisualStyleBackColor = true;
            visaKategorier.Visible = false;
            visaKategorier.Click += visaKategorier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 808);
            Controls.Add(poddTabbar);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            poddTabbar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button uppdateraPoddFlöde;
        private TextBox URL;
        private Button sparaPodd;
        private Button raderapodd;
        private Button skapanyKategori;
        private TabControl poddTabbar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RichTextBox avsnittBeskrivning;
        private Button uppdateraPoddlistaMinaSidor;
        private DateTimePicker senareDatum;
        private DateTimePicker tidigareDatum;
        private Button publiceringsDatum;
        private ComboBox sorteraKategorierMinaSidor;
        private Button visaKategorier;
        private ListBox listaAvsnittBox;
        private RichTextBox beskrivningsBoxMinaSidor;
        private ListBox listaAvsnittMinaSidor;
        private ListBox listaPodcastMinaSidor;
        private TextBox skapaKategoriText;
        private TextBox redigeraKategori;
        private ComboBox allaKategorier;
        private Button redigeraKategoriKnapp;
        private ComboBox KategorierFörPodcast;
        private Button TaBortKategoriFrånPodcast;
        private Button LäggTillPodcastIKategori;
        private Button bytNamnKnapp;
        private TextBox nyttNamnRuta;
        private ListBox listaPodcastKategori;
        private ListBox listaKategorier;
        private Button VisaPodcastKategori;
        private Button taBortKategori;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label13;
        private Label label17;
        private Label label15;
        private Label label18;
        private Label label16;
    }
}
