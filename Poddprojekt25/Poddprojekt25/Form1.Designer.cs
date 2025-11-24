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
            label17 = new Label();
            label15 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            taBortKategori = new Button();
            VisaPodcastKategori = new Button();
            listaPodcastKategori = new ListBox();
            listaKategorier = new ListBox();
            button2 = new Button();
            button1 = new Button();
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
            uppdateraPoddFlöde.Location = new Point(358, 79);
            uppdateraPoddFlöde.Name = "uppdateraPoddFlöde";
            uppdateraPoddFlöde.Size = new Size(118, 29);
            uppdateraPoddFlöde.TabIndex = 1;
            uppdateraPoddFlöde.Text = "Visa podcast\r\n";
            uppdateraPoddFlöde.UseVisualStyleBackColor = true;
            uppdateraPoddFlöde.Click += visapoddFlöde_Click;
            // 
            // URL
            // 
            URL.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            URL.Location = new Point(50, 82);
            URL.Name = "URL";
            URL.Size = new Size(253, 25);
            URL.TabIndex = 4;
            URL.TextChanged += URLOchMinaSparade_TextChanged;
            // 
            // sparaPodd
            // 
            sparaPodd.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sparaPodd.Location = new Point(154, 456);
            sparaPodd.Name = "sparaPodd";
            sparaPodd.Size = new Size(124, 29);
            sparaPodd.TabIndex = 5;
            sparaPodd.Text = "Spara podcast\r\n";
            sparaPodd.UseVisualStyleBackColor = true;
            sparaPodd.Click += sparaPodd_Click;
            // 
            // raderapodd
            // 
            raderapodd.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            raderapodd.Location = new Point(896, 218);
            raderapodd.Name = "raderapodd";
            raderapodd.Size = new Size(134, 29);
            raderapodd.TabIndex = 8;
            raderapodd.Text = "Radera podcast\r\n";
            raderapodd.UseVisualStyleBackColor = true;
            raderapodd.Click += raderapodd_Click;
            // 
            // skapanyKategori
            // 
            skapanyKategori.Font = new Font("Cambria", 9F);
            skapanyKategori.Location = new Point(806, 147);
            skapanyKategori.Name = "skapanyKategori";
            skapanyKategori.Size = new Size(83, 29);
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
            poddTabbar.Name = "poddTabbar";
            poddTabbar.SelectedIndex = 0;
            poddTabbar.Size = new Size(1075, 656);
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1067, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Startsida";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label12.Location = new Point(325, 173);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 22);
            label12.TabIndex = 18;
            label12.Text = "Beskrivning";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label11.Location = new Point(49, 173);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 22);
            label11.TabIndex = 17;
            label11.Text = "Avsnitt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 39);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(517, 22);
            label5.TabIndex = 16;
            label5.Text = "Klistra in en URL-adress för att lägga till en podcast i listan";
            // 
            // listaAvsnittBox
            // 
            listaAvsnittBox.FormattingEnabled = true;
            listaAvsnittBox.Location = new Point(49, 210);
            listaAvsnittBox.Name = "listaAvsnittBox";
            listaAvsnittBox.Size = new Size(230, 208);
            listaAvsnittBox.TabIndex = 15;
            listaAvsnittBox.SelectedIndexChanged += listaAvsnittBox_SelectedIndexChanged;
            // 
            // avsnittBeskrivning
            // 
            avsnittBeskrivning.Location = new Point(325, 210);
            avsnittBeskrivning.Name = "avsnittBeskrivning";
            avsnittBeskrivning.Size = new Size(424, 222);
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1067, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sparade podcasts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(49, 248);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(406, 22);
            label14.TabIndex = 31;
            label14.Text = "Markera ett avsnitt för att se mer information\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(50, 46);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(326, 22);
            label13.TabIndex = 30;
            label13.Text = "Markera en podcast för att se avsnitt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label7.Location = new Point(144, 527);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 22);
            label7.TabIndex = 29;
            label7.Text = "till";
            // 
            // beskrivningsBoxMinaSidor
            // 
            beskrivningsBoxMinaSidor.Location = new Point(453, 287);
            beskrivningsBoxMinaSidor.Name = "beskrivningsBoxMinaSidor";
            beskrivningsBoxMinaSidor.Size = new Size(534, 138);
            beskrivningsBoxMinaSidor.TabIndex = 21;
            beskrivningsBoxMinaSidor.Text = "";
            beskrivningsBoxMinaSidor.TextChanged += richTextBox1_TextChanged;
            // 
            // uppdateraPoddlistaMinaSidor
            // 
            uppdateraPoddlistaMinaSidor.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uppdateraPoddlistaMinaSidor.Location = new Point(444, 19);
            uppdateraPoddlistaMinaSidor.Name = "uppdateraPoddlistaMinaSidor";
            uppdateraPoddlistaMinaSidor.Size = new Size(127, 29);
            uppdateraPoddlistaMinaSidor.TabIndex = 17;
            uppdateraPoddlistaMinaSidor.Text = "Visa podcasts";
            uppdateraPoddlistaMinaSidor.UseVisualStyleBackColor = true;
            uppdateraPoddlistaMinaSidor.Click += uppdateraPoddlistaMinaSidor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label6.Location = new Point(144, 494);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 22);
            label6.TabIndex = 28;
            label6.Text = "från";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label4.Location = new Point(74, 458);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(338, 22);
            label4.TabIndex = 27;
            label4.Text = "Sortera podcasts efter datumintervall";
            // 
            // listaAvsnittMinaSidor
            // 
            listaAvsnittMinaSidor.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaAvsnittMinaSidor.FormattingEnabled = true;
            listaAvsnittMinaSidor.Location = new Point(50, 287);
            listaAvsnittMinaSidor.Name = "listaAvsnittMinaSidor";
            listaAvsnittMinaSidor.Size = new Size(340, 123);
            listaAvsnittMinaSidor.TabIndex = 20;
            listaAvsnittMinaSidor.SelectedIndexChanged += listaAvsnittMinaSidor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label3.Location = new Point(407, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(281, 22);
            label3.TabIndex = 26;
            label3.Text = "Sortera podcasts efter kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(711, 186);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(339, 22);
            label2.TabIndex = 25;
            label2.Text = "Markera en podcast för att radera den";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold);
            label1.Location = new Point(702, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 22);
            label1.TabIndex = 24;
            label1.Text = "Markera en podcast för att ändra namn";
            // 
            // publiceringsDatum
            // 
            publiceringsDatum.Font = new Font("Cambria", 9F);
            publiceringsDatum.Location = new Point(219, 562);
            publiceringsDatum.Name = "publiceringsDatum";
            publiceringsDatum.Size = new Size(170, 29);
            publiceringsDatum.TabIndex = 13;
            publiceringsDatum.Text = "Sök publiceringsdatum";
            publiceringsDatum.UseVisualStyleBackColor = true;
            publiceringsDatum.Click += publiceringsDatum_Click;
            // 
            // bytNamnKnapp
            // 
            bytNamnKnapp.Font = new Font("Cambria", 9F);
            bytNamnKnapp.Location = new Point(946, 121);
            bytNamnKnapp.Name = "bytNamnKnapp";
            bytNamnKnapp.Size = new Size(85, 29);
            bytNamnKnapp.TabIndex = 23;
            bytNamnKnapp.Text = "Ändra";
            bytNamnKnapp.UseVisualStyleBackColor = true;
            bytNamnKnapp.Click += bytNamnKnapp_Click;
            // 
            // tidigareDatum
            // 
            tidigareDatum.Font = new Font("Cambria", 9F);
            tidigareDatum.Location = new Point(204, 495);
            tidigareDatum.Name = "tidigareDatum";
            tidigareDatum.Size = new Size(186, 25);
            tidigareDatum.TabIndex = 11;
            // 
            // nyttNamnRuta
            // 
            nyttNamnRuta.Font = new Font("Cambria", 9F);
            nyttNamnRuta.Location = new Point(782, 121);
            nyttNamnRuta.Name = "nyttNamnRuta";
            nyttNamnRuta.Size = new Size(136, 25);
            nyttNamnRuta.TabIndex = 22;
            nyttNamnRuta.Text = "Skriv nytt namn...";
            // 
            // senareDatum
            // 
            senareDatum.Font = new Font("Cambria", 9F);
            senareDatum.Location = new Point(204, 525);
            senareDatum.Name = "senareDatum";
            senareDatum.Size = new Size(186, 25);
            senareDatum.TabIndex = 12;
            senareDatum.ValueChanged += senareDatum_ValueChanged;
            // 
            // listaPodcastMinaSidor
            // 
            listaPodcastMinaSidor.Font = new Font("Cambria", 9F);
            listaPodcastMinaSidor.FormattingEnabled = true;
            listaPodcastMinaSidor.Location = new Point(50, 86);
            listaPodcastMinaSidor.Name = "listaPodcastMinaSidor";
            listaPodcastMinaSidor.Size = new Size(340, 106);
            listaPodcastMinaSidor.TabIndex = 19;
            listaPodcastMinaSidor.SelectedIndexChanged += listaPodcastMinaSidor_SelectedIndexChanged;
            // 
            // sorteraKategorierMinaSidor
            // 
            sorteraKategorierMinaSidor.Font = new Font("Cambria", 9F);
            sorteraKategorierMinaSidor.FormattingEnabled = true;
            sorteraKategorierMinaSidor.Location = new Point(518, 118);
            sorteraKategorierMinaSidor.Name = "sorteraKategorierMinaSidor";
            sorteraKategorierMinaSidor.Size = new Size(151, 25);
            sorteraKategorierMinaSidor.TabIndex = 18;
            sorteraKategorierMinaSidor.SelectedIndexChanged += sorteraKategorier2_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(taBortKategori);
            tabPage3.Controls.Add(VisaPodcastKategori);
            tabPage3.Controls.Add(listaPodcastKategori);
            tabPage3.Controls.Add(listaKategorier);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(KategorierFörPodcast);
            tabPage3.Controls.Add(allaKategorier);
            tabPage3.Controls.Add(redigeraKategoriKnapp);
            tabPage3.Controls.Add(redigeraKategori);
            tabPage3.Controls.Add(skapaKategoriText);
            tabPage3.Controls.Add(visaKategorier);
            tabPage3.Controls.Add(skapanyKategori);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1067, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kategorier";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(44, 249);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(386, 44);
            label17.TabIndex = 34;
            label17.Text = "Markera en podcast och välj en kategori du \r\n                                                   vill lägga till den i";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(44, 409);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(386, 44);
            label15.TabIndex = 32;
            label15.Text = "Markera en podcast och välj en kategori du \r\n                                               vill ta bort ifrån den";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(703, 270);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(331, 22);
            label10.TabIndex = 31;
            label10.Text = "Markera en kategori och ändra namn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(806, 74);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(164, 22);
            label9.TabIndex = 30;
            label9.Text = "Skapa ny kategori";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(690, 430);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(345, 22);
            label8.TabIndex = 29;
            label8.Text = "Markera en kategori för att radera den";
            // 
            // taBortKategori
            // 
            taBortKategori.Font = new Font("Cambria", 9F);
            taBortKategori.Location = new Point(932, 464);
            taBortKategori.Name = "taBortKategori";
            taBortKategori.Size = new Size(83, 29);
            taBortKategori.TabIndex = 28;
            taBortKategori.Text = "Radera";
            taBortKategori.UseVisualStyleBackColor = true;
            taBortKategori.Click += taBortKategori_Click;
            // 
            // VisaPodcastKategori
            // 
            VisaPodcastKategori.Font = new Font("Cambria", 9F);
            VisaPodcastKategori.Location = new Point(290, 6);
            VisaPodcastKategori.Name = "VisaPodcastKategori";
            VisaPodcastKategori.Size = new Size(109, 29);
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
            listaPodcastKategori.Location = new Point(44, 60);
            listaPodcastKategori.Name = "listaPodcastKategori";
            listaPodcastKategori.Size = new Size(355, 140);
            listaPodcastKategori.TabIndex = 26;
            listaPodcastKategori.SelectedIndexChanged += listaPodcastKategori_SelectedIndexChanged;
            // 
            // listaKategorier
            // 
            listaKategorier.Font = new Font("Cambria", 9F);
            listaKategorier.FormattingEnabled = true;
            listaKategorier.Location = new Point(498, 60);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(267, 140);
            listaKategorier.TabIndex = 25;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 9F);
            button2.Location = new Point(314, 506);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "Ta bort";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 9F);
            button1.Location = new Point(302, 346);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "Bekräfta";
            button1.UseVisualStyleBackColor = true;
            // 
            // KategorierFörPodcast
            // 
            KategorierFörPodcast.Font = new Font("Cambria", 9F);
            KategorierFörPodcast.FormattingEnabled = true;
            KategorierFörPodcast.Location = new Point(210, 468);
            KategorierFörPodcast.Name = "KategorierFörPodcast";
            KategorierFörPodcast.Size = new Size(199, 25);
            KategorierFörPodcast.TabIndex = 22;
            // 
            // allaKategorier
            // 
            allaKategorier.Font = new Font("Cambria", 9F);
            allaKategorier.FormattingEnabled = true;
            allaKategorier.Location = new Point(210, 309);
            allaKategorier.Name = "allaKategorier";
            allaKategorier.Size = new Size(187, 25);
            allaKategorier.TabIndex = 21;
            allaKategorier.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // redigeraKategoriKnapp
            // 
            redigeraKategoriKnapp.Font = new Font("Cambria", 9F);
            redigeraKategoriKnapp.Location = new Point(921, 346);
            redigeraKategoriKnapp.Name = "redigeraKategoriKnapp";
            redigeraKategoriKnapp.Size = new Size(94, 29);
            redigeraKategoriKnapp.TabIndex = 20;
            redigeraKategoriKnapp.Text = "Ändra namn";
            redigeraKategoriKnapp.UseVisualStyleBackColor = true;
            redigeraKategoriKnapp.Click += redigeraKategoriKnapp_Click;
            // 
            // redigeraKategori
            // 
            redigeraKategori.Font = new Font("Cambria", 9F);
            redigeraKategori.Location = new Point(806, 309);
            redigeraKategori.Name = "redigeraKategori";
            redigeraKategori.Size = new Size(210, 25);
            redigeraKategori.TabIndex = 19;
            // 
            // skapaKategoriText
            // 
            skapaKategoriText.Font = new Font("Cambria", 9F);
            skapaKategoriText.Location = new Point(806, 108);
            skapaKategoriText.Name = "skapaKategoriText";
            skapaKategoriText.Size = new Size(210, 25);
            skapaKategoriText.TabIndex = 18;
            // 
            // visaKategorier
            // 
            visaKategorier.Font = new Font("Cambria", 9F);
            visaKategorier.Location = new Point(642, 6);
            visaKategorier.Name = "visaKategorier";
            visaKategorier.Size = new Size(123, 29);
            visaKategorier.TabIndex = 15;
            visaKategorier.Text = "Visa kategorier";
            visaKategorier.UseVisualStyleBackColor = true;
            visaKategorier.Visible = false;
            visaKategorier.Click += visaKategorier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 646);
            Controls.Add(poddTabbar);
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
        private Button button2;
        private Button button1;
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
    }
}
