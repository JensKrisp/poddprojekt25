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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uppdateraPoddFlöde = new Button();
            URL = new TextBox();
            sparaPodd = new Button();
            raderapodd = new Button();
            skapanyKategori = new Button();
            poddTabbar = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            listaAvsnittBox = new ListBox();
            avsnittBeskrivning = new RichTextBox();
            tabPage2 = new TabPage();
            listaAvsnittMinaSidor = new ListBox();
            InformatIonMinaSidor = new Label();
            bytNamnKnapp = new Button();
            senareDatum = new DateTimePicker();
            tidigareDatum = new DateTimePicker();
            publiceringsDatum = new Button();
            nyttNamnRuta = new TextBox();
            beskrivningsBoxMinaSidor = new RichTextBox();
            listaPodcastMinaSidor = new ListBox();
            sorteraKategorierMinaSidor = new ComboBox();
            uppdateraPoddlistaMinaSidor = new Button();
            tabPage3 = new TabPage();
            richTextBox1 = new RichTextBox();
            taBortKategori = new Button();
            VisaPodcastKategori = new Button();
            listaPodcastKategori = new ListBox();
            listaKategorier = new ListBox();
            läggTillKategoriIPodcast = new Button();
            taBortKategoriFrånProjekt = new Button();
            allaKategorier = new ComboBox();
            KategorierFörPodcast = new ComboBox();
            redigeraKategoriKnapp = new Button();
            redigeraKategori = new TextBox();
            skapaKategoriText = new TextBox();
            visaKategorier = new Button();
            StartsidaLbl = new Label();
            poddTabbar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // uppdateraPoddFlöde
            // 
            uppdateraPoddFlöde.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            uppdateraPoddFlöde.Location = new Point(0, 483);
            uppdateraPoddFlöde.Name = "uppdateraPoddFlöde";
            uppdateraPoddFlöde.Size = new Size(120, 29);
            uppdateraPoddFlöde.TabIndex = 1;
            uppdateraPoddFlöde.Text = "Uppdatera";
            uppdateraPoddFlöde.UseVisualStyleBackColor = true;
            uppdateraPoddFlöde.Click += visapoddFlöde_Click;
            // 
            // URL
            // 
            URL.Location = new Point(3, 450);
            URL.Name = "URL";
            URL.Size = new Size(221, 27);
            URL.TabIndex = 4;
            URL.TextChanged += URLOchMinaSparade_TextChanged;
            // 
            // sparaPodd
            // 
            sparaPodd.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            sparaPodd.Location = new Point(126, 483);
            sparaPodd.Name = "sparaPodd";
            sparaPodd.Size = new Size(94, 29);
            sparaPodd.TabIndex = 5;
            sparaPodd.Text = "Spara";
            sparaPodd.UseVisualStyleBackColor = true;
            sparaPodd.Click += sparaPodd_Click;
            // 
            // raderapodd
            // 
            raderapodd.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raderapodd.Location = new Point(183, 108);
            raderapodd.Name = "raderapodd";
            raderapodd.Size = new Size(125, 29);
            raderapodd.TabIndex = 8;
            raderapodd.Text = "Radera";
            raderapodd.UseVisualStyleBackColor = true;
            raderapodd.Click += raderapodd_Click;
            // 
            // skapanyKategori
            // 
            skapanyKategori.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            skapanyKategori.Location = new Point(480, 51);
            skapanyKategori.Name = "skapanyKategori";
            skapanyKategori.Size = new Size(94, 29);
            skapanyKategori.TabIndex = 10;
            skapanyKategori.Text = "Skapa";
            skapanyKategori.UseVisualStyleBackColor = true;
            skapanyKategori.Click += skapanyKategori_Click;
            // 
            // poddTabbar
            // 
            poddTabbar.Controls.Add(tabPage1);
            poddTabbar.Controls.Add(tabPage2);
            poddTabbar.Controls.Add(tabPage3);
            poddTabbar.Location = new Point(-2, -1);
            poddTabbar.Name = "poddTabbar";
            poddTabbar.SelectedIndex = 0;
            poddTabbar.Size = new Size(1109, 583);
            poddTabbar.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(StartsidaLbl);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listaAvsnittBox);
            tabPage1.Controls.Add(avsnittBeskrivning);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(sparaPodd);
            tabPage1.Controls.Add(uppdateraPoddFlöde);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1101, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Start";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.Location = new Point(244, 460);
            label1.Name = "label1";
            label1.Size = new Size(356, 17);
            label1.TabIndex = 16;
            label1.Text = "Skriv in URL och klicka på uppdatera för att se flödet";
            // 
            // listaAvsnittBox
            // 
            listaAvsnittBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            listaAvsnittBox.FormattingEnabled = true;
            listaAvsnittBox.Location = new Point(3, 83);
            listaAvsnittBox.Name = "listaAvsnittBox";
            listaAvsnittBox.Size = new Size(221, 361);
            listaAvsnittBox.TabIndex = 15;
            listaAvsnittBox.SelectedIndexChanged += listaAvsnittBox_SelectedIndexChanged;
            // 
            // avsnittBeskrivning
            // 
            avsnittBeskrivning.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            avsnittBeskrivning.Location = new Point(244, 83);
            avsnittBeskrivning.Name = "avsnittBeskrivning";
            avsnittBeskrivning.Size = new Size(328, 361);
            avsnittBeskrivning.TabIndex = 10;
            avsnittBeskrivning.Text = "Välkommen till Poddsystemet, uppdatera listan och klicka på ett avsnitt för att läsa mer,\nOm du vill spara podden till senare, klicka på spara.\n\n";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Transparent;
            tabPage2.Controls.Add(listaAvsnittMinaSidor);
            tabPage2.Controls.Add(InformatIonMinaSidor);
            tabPage2.Controls.Add(bytNamnKnapp);
            tabPage2.Controls.Add(senareDatum);
            tabPage2.Controls.Add(tidigareDatum);
            tabPage2.Controls.Add(publiceringsDatum);
            tabPage2.Controls.Add(nyttNamnRuta);
            tabPage2.Controls.Add(beskrivningsBoxMinaSidor);
            tabPage2.Controls.Add(listaPodcastMinaSidor);
            tabPage2.Controls.Add(sorteraKategorierMinaSidor);
            tabPage2.Controls.Add(uppdateraPoddlistaMinaSidor);
            tabPage2.Controls.Add(raderapodd);
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1101, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mina Sidor";
            // 
            // listaAvsnittMinaSidor
            // 
            listaAvsnittMinaSidor.BackColor = SystemColors.ControlDark;
            listaAvsnittMinaSidor.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            listaAvsnittMinaSidor.ForeColor = Color.Black;
            listaAvsnittMinaSidor.FormattingEnabled = true;
            listaAvsnittMinaSidor.Location = new Point(314, 0);
            listaAvsnittMinaSidor.Name = "listaAvsnittMinaSidor";
            listaAvsnittMinaSidor.Size = new Size(185, 293);
            listaAvsnittMinaSidor.TabIndex = 20;
            listaAvsnittMinaSidor.SelectedIndexChanged += listaAvsnittMinaSidor_SelectedIndexChanged;
            // 
            // InformatIonMinaSidor
            // 
            InformatIonMinaSidor.AutoSize = true;
            InformatIonMinaSidor.Location = new Point(10, 3);
            InformatIonMinaSidor.Name = "InformatIonMinaSidor";
            InformatIonMinaSidor.Size = new Size(0, 20);
            InformatIonMinaSidor.TabIndex = 24;
            // 
            // bytNamnKnapp
            // 
            bytNamnKnapp.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bytNamnKnapp.Location = new Point(183, 73);
            bytNamnKnapp.Name = "bytNamnKnapp";
            bytNamnKnapp.Size = new Size(125, 29);
            bytNamnKnapp.TabIndex = 23;
            bytNamnKnapp.Text = "Ändra namn";
            bytNamnKnapp.UseVisualStyleBackColor = true;
            bytNamnKnapp.Click += bytNamnKnapp_Click;
            // 
            // senareDatum
            // 
            senareDatum.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            senareDatum.Location = new Point(314, 299);
            senareDatum.Name = "senareDatum";
            senareDatum.Size = new Size(82, 25);
            senareDatum.TabIndex = 12;
            // 
            // tidigareDatum
            // 
            tidigareDatum.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            tidigareDatum.Location = new Point(417, 299);
            tidigareDatum.Name = "tidigareDatum";
            tidigareDatum.Size = new Size(82, 25);
            tidigareDatum.TabIndex = 11;
            // 
            // publiceringsDatum
            // 
            publiceringsDatum.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            publiceringsDatum.Location = new Point(314, 330);
            publiceringsDatum.Name = "publiceringsDatum";
            publiceringsDatum.Size = new Size(185, 29);
            publiceringsDatum.TabIndex = 13;
            publiceringsDatum.Text = "sök publiceringsdatum";
            publiceringsDatum.UseVisualStyleBackColor = true;
            publiceringsDatum.Click += publiceringsDatum_Click;
            // 
            // nyttNamnRuta
            // 
            nyttNamnRuta.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nyttNamnRuta.Location = new Point(183, 40);
            nyttNamnRuta.Name = "nyttNamnRuta";
            nyttNamnRuta.Size = new Size(125, 25);
            nyttNamnRuta.TabIndex = 22;
            // 
            // beskrivningsBoxMinaSidor
            // 
            beskrivningsBoxMinaSidor.BackColor = SystemColors.ControlDark;
            beskrivningsBoxMinaSidor.BorderStyle = BorderStyle.None;
            beskrivningsBoxMinaSidor.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            beskrivningsBoxMinaSidor.Location = new Point(680, 0);
            beskrivningsBoxMinaSidor.Name = "beskrivningsBoxMinaSidor";
            beskrivningsBoxMinaSidor.ReadOnly = true;
            beskrivningsBoxMinaSidor.Size = new Size(409, 301);
            beskrivningsBoxMinaSidor.TabIndex = 21;
            beskrivningsBoxMinaSidor.Text = resources.GetString("beskrivningsBoxMinaSidor.Text");
            beskrivningsBoxMinaSidor.TextChanged += richTextBox1_TextChanged;
            // 
            // listaPodcastMinaSidor
            // 
            listaPodcastMinaSidor.BackColor = SystemColors.ControlDark;
            listaPodcastMinaSidor.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listaPodcastMinaSidor.FormattingEnabled = true;
            listaPodcastMinaSidor.Location = new Point(10, 3);
            listaPodcastMinaSidor.Name = "listaPodcastMinaSidor";
            listaPodcastMinaSidor.Size = new Size(174, 293);
            listaPodcastMinaSidor.TabIndex = 19;
            listaPodcastMinaSidor.SelectedIndexChanged += listaPodcastMinaSidor_SelectedIndexChanged;
            // 
            // sorteraKategorierMinaSidor
            // 
            sorteraKategorierMinaSidor.BackColor = SystemColors.ControlDark;
            sorteraKategorierMinaSidor.FormattingEnabled = true;
            sorteraKategorierMinaSidor.Location = new Point(183, 3);
            sorteraKategorierMinaSidor.Name = "sorteraKategorierMinaSidor";
            sorteraKategorierMinaSidor.Size = new Size(125, 28);
            sorteraKategorierMinaSidor.TabIndex = 18;
            sorteraKategorierMinaSidor.SelectedIndexChanged += sorteraKategorier2_SelectedIndexChanged;
            // 
            // uppdateraPoddlistaMinaSidor
            // 
            uppdateraPoddlistaMinaSidor.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uppdateraPoddlistaMinaSidor.Location = new Point(183, 278);
            uppdateraPoddlistaMinaSidor.Name = "uppdateraPoddlistaMinaSidor";
            uppdateraPoddlistaMinaSidor.Size = new Size(125, 29);
            uppdateraPoddlistaMinaSidor.TabIndex = 17;
            uppdateraPoddlistaMinaSidor.Text = "Uppdatera";
            uppdateraPoddlistaMinaSidor.UseVisualStyleBackColor = true;
            uppdateraPoddlistaMinaSidor.Click += uppdateraPoddlistaMinaSidor_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Controls.Add(taBortKategori);
            tabPage3.Controls.Add(VisaPodcastKategori);
            tabPage3.Controls.Add(listaPodcastKategori);
            tabPage3.Controls.Add(listaKategorier);
            tabPage3.Controls.Add(läggTillKategoriIPodcast);
            tabPage3.Controls.Add(taBortKategoriFrånProjekt);
            tabPage3.Controls.Add(allaKategorier);
            tabPage3.Controls.Add(KategorierFörPodcast);
            tabPage3.Controls.Add(redigeraKategoriKnapp);
            tabPage3.Controls.Add(redigeraKategori);
            tabPage3.Controls.Add(skapaKategoriText);
            tabPage3.Controls.Add(visaKategorier);
            tabPage3.Controls.Add(skapanyKategori);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1101, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kategorihantering";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            richTextBox1.Location = new Point(655, 16);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(275, 346);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // taBortKategori
            // 
            taBortKategori.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            taBortKategori.Location = new Point(480, 190);
            taBortKategori.Name = "taBortKategori";
            taBortKategori.Size = new Size(94, 29);
            taBortKategori.TabIndex = 28;
            taBortKategori.Text = "ta bort";
            taBortKategori.UseVisualStyleBackColor = true;
            taBortKategori.Click += taBortKategori_Click;
            // 
            // VisaPodcastKategori
            // 
            VisaPodcastKategori.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            VisaPodcastKategori.Location = new Point(167, 333);
            VisaPodcastKategori.Name = "VisaPodcastKategori";
            VisaPodcastKategori.Size = new Size(94, 29);
            VisaPodcastKategori.TabIndex = 27;
            VisaPodcastKategori.Text = "Uppdatera";
            VisaPodcastKategori.UseVisualStyleBackColor = true;
            VisaPodcastKategori.Click += VisaPodcastKategori_Click;
            // 
            // listaPodcastKategori
            // 
            listaPodcastKategori.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            listaPodcastKategori.FormattingEnabled = true;
            listaPodcastKategori.Location = new Point(11, 18);
            listaPodcastKategori.Name = "listaPodcastKategori";
            listaPodcastKategori.Size = new Size(150, 344);
            listaPodcastKategori.TabIndex = 26;
            listaPodcastKategori.SelectedIndexChanged += listaPodcastKategori_SelectedIndexChanged;
            // 
            // listaKategorier
            // 
            listaKategorier.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            listaKategorier.FormattingEnabled = true;
            listaKategorier.Location = new Point(324, 18);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(150, 344);
            listaKategorier.TabIndex = 25;
            // 
            // läggTillKategoriIPodcast
            // 
            läggTillKategoriIPodcast.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            läggTillKategoriIPodcast.Location = new Point(167, 150);
            läggTillKategoriIPodcast.Name = "läggTillKategoriIPodcast";
            läggTillKategoriIPodcast.Size = new Size(94, 29);
            läggTillKategoriIPodcast.TabIndex = 24;
            läggTillKategoriIPodcast.Text = "lägg till";
            läggTillKategoriIPodcast.UseVisualStyleBackColor = true;
            läggTillKategoriIPodcast.Click += läggTillKategoriIPodcast_Click;
            // 
            // taBortKategoriFrånProjekt
            // 
            taBortKategoriFrånProjekt.BackgroundImageLayout = ImageLayout.None;
            taBortKategoriFrånProjekt.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            taBortKategoriFrånProjekt.Location = new Point(167, 52);
            taBortKategoriFrånProjekt.Name = "taBortKategoriFrånProjekt";
            taBortKategoriFrånProjekt.Size = new Size(94, 29);
            taBortKategoriFrånProjekt.TabIndex = 23;
            taBortKategoriFrånProjekt.Text = "ta bort";
            taBortKategoriFrånProjekt.UseVisualStyleBackColor = true;
            taBortKategoriFrånProjekt.Click += taBortKategoriFrånProjekt_Click;
            // 
            // allaKategorier
            // 
            allaKategorier.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            allaKategorier.FormattingEnabled = true;
            allaKategorier.Location = new Point(167, 116);
            allaKategorier.Name = "allaKategorier";
            allaKategorier.Size = new Size(151, 25);
            allaKategorier.TabIndex = 22;
            allaKategorier.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // KategorierFörPodcast
            // 
            KategorierFörPodcast.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            KategorierFörPodcast.FormattingEnabled = true;
            KategorierFörPodcast.Location = new Point(167, 18);
            KategorierFörPodcast.Name = "KategorierFörPodcast";
            KategorierFörPodcast.Size = new Size(151, 25);
            KategorierFörPodcast.TabIndex = 21;
            KategorierFörPodcast.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // redigeraKategoriKnapp
            // 
            redigeraKategoriKnapp.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            redigeraKategoriKnapp.Location = new Point(480, 119);
            redigeraKategoriKnapp.Name = "redigeraKategoriKnapp";
            redigeraKategoriKnapp.Size = new Size(94, 29);
            redigeraKategoriKnapp.TabIndex = 20;
            redigeraKategoriKnapp.Text = "ändra namn";
            redigeraKategoriKnapp.UseVisualStyleBackColor = true;
            redigeraKategoriKnapp.Click += redigeraKategoriKnapp_Click;
            // 
            // redigeraKategori
            // 
            redigeraKategori.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            redigeraKategori.Location = new Point(480, 86);
            redigeraKategori.Name = "redigeraKategori";
            redigeraKategori.Size = new Size(125, 25);
            redigeraKategori.TabIndex = 19;
            // 
            // skapaKategoriText
            // 
            skapaKategoriText.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            skapaKategoriText.Location = new Point(480, 18);
            skapaKategoriText.Name = "skapaKategoriText";
            skapaKategoriText.Size = new Size(125, 25);
            skapaKategoriText.TabIndex = 18;
            // 
            // visaKategorier
            // 
            visaKategorier.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            visaKategorier.Location = new Point(480, 333);
            visaKategorier.Name = "visaKategorier";
            visaKategorier.Size = new Size(94, 29);
            visaKategorier.TabIndex = 15;
            visaKategorier.Text = "Uppdatera";
            visaKategorier.UseVisualStyleBackColor = true;
            visaKategorier.Click += visaKategorier_Click;
            // 
            // StartsidaLbl
            // 
            StartsidaLbl.AutoSize = true;
            StartsidaLbl.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartsidaLbl.Location = new Point(157, 23);
            StartsidaLbl.Name = "StartsidaLbl";
            StartsidaLbl.Size = new Size(143, 29);
            StartsidaLbl.TabIndex = 17;
            StartsidaLbl.Text = "Startsida";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 583);
            Controls.Add(poddTabbar);
            Name = "Form1";
            Text = "Form1";
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
        private ComboBox KategorierFörPodcast;
        private Button redigeraKategoriKnapp;
        private ComboBox allaKategorier;
        private Button läggTillKategoriIPodcast;
        private Button taBortKategoriFrånProjekt;
        private Button bytNamnKnapp;
        private TextBox nyttNamnRuta;
        private ListBox listaPodcastKategori;
        private ListBox listaKategorier;
        private Button VisaPodcastKategori;
        private Button taBortKategori;
        private Label label1;
        private Label InformatIonMinaSidor;
        private RichTextBox richTextBox1;
        private Label StartsidaLbl;
    }
}
