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
            listaAvsnittBox = new ListBox();
            sorteraKategorier = new ComboBox();
            publiceringsDatum = new Button();
            senareDatum = new DateTimePicker();
            tidigareDatum = new DateTimePicker();
            avsnittBeskrivning = new RichTextBox();
            tabPage2 = new TabPage();
            beskrivningsBoxMinaSidor = new RichTextBox();
            listaAvsnittMinaSidor = new ListBox();
            listaPodcastMinaSidor = new ListBox();
            sorteraKategorier2 = new ComboBox();
            uppdateraPoddlistaMinaSidor = new Button();
            tabPage3 = new TabPage();
            skapaKategoriText = new TextBox();
            visaKategorier = new Button();
            listaKategorier = new ListView();
            listaPoddarKategori = new ListView();
            redigeraKategori = new TextBox();
            redigeraKategoriKnapp = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            poddTabbar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // uppdateraPoddFlöde
            // 
            uppdateraPoddFlöde.Location = new Point(6, 306);
            uppdateraPoddFlöde.Name = "uppdateraPoddFlöde";
            uppdateraPoddFlöde.Size = new Size(94, 29);
            uppdateraPoddFlöde.TabIndex = 1;
            uppdateraPoddFlöde.Text = "uppdatFlöde";
            uppdateraPoddFlöde.UseVisualStyleBackColor = true;
            uppdateraPoddFlöde.Click += visapoddFlöde_Click;
            // 
            // URL
            // 
            URL.Location = new Point(23, 13);
            URL.Name = "URL";
            URL.Size = new Size(221, 27);
            URL.TabIndex = 4;
            URL.Text = "URL";
            URL.TextChanged += URLOchMinaSparade_TextChanged;
            // 
            // sparaPodd
            // 
            sparaPodd.Location = new Point(6, 341);
            sparaPodd.Name = "sparaPodd";
            sparaPodd.Size = new Size(94, 29);
            sparaPodd.TabIndex = 5;
            sparaPodd.Text = "sparaPodd";
            sparaPodd.UseVisualStyleBackColor = true;
            sparaPodd.Click += sparaPodd_Click;
            // 
            // raderapodd
            // 
            raderapodd.Location = new Point(132, 342);
            raderapodd.Name = "raderapodd";
            raderapodd.Size = new Size(94, 29);
            raderapodd.TabIndex = 8;
            raderapodd.Text = "raderaPodd";
            raderapodd.UseVisualStyleBackColor = true;
            raderapodd.Click += raderapodd_Click;
            // 
            // skapanyKategori
            // 
            skapanyKategori.Location = new Point(659, 47);
            skapanyKategori.Name = "skapanyKategori";
            skapanyKategori.Size = new Size(94, 29);
            skapanyKategori.TabIndex = 10;
            skapanyKategori.Text = "skapaNyKategori";
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
            poddTabbar.Size = new Size(800, 447);
            poddTabbar.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listaAvsnittBox);
            tabPage1.Controls.Add(sorteraKategorier);
            tabPage1.Controls.Add(publiceringsDatum);
            tabPage1.Controls.Add(senareDatum);
            tabPage1.Controls.Add(tidigareDatum);
            tabPage1.Controls.Add(avsnittBeskrivning);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(sparaPodd);
            tabPage1.Controls.Add(uppdateraPoddFlöde);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listaAvsnittBox
            // 
            listaAvsnittBox.FormattingEnabled = true;
            listaAvsnittBox.Location = new Point(23, 63);
            listaAvsnittBox.Name = "listaAvsnittBox";
            listaAvsnittBox.Size = new Size(175, 224);
            listaAvsnittBox.TabIndex = 15;
            listaAvsnittBox.SelectedIndexChanged += listaAvsnittBox_SelectedIndexChanged;
            // 
            // sorteraKategorier
            // 
            sorteraKategorier.FormattingEnabled = true;
            sorteraKategorier.Location = new Point(314, 339);
            sorteraKategorier.Name = "sorteraKategorier";
            sorteraKategorier.Size = new Size(151, 28);
            sorteraKategorier.TabIndex = 14;
            sorteraKategorier.SelectedIndexChanged += sorteraKategorier_SelectedIndexChanged;
            // 
            // publiceringsDatum
            // 
            publiceringsDatum.Location = new Point(204, 339);
            publiceringsDatum.Name = "publiceringsDatum";
            publiceringsDatum.Size = new Size(94, 29);
            publiceringsDatum.TabIndex = 13;
            publiceringsDatum.Text = "sök publiceringsdatum";
            publiceringsDatum.UseVisualStyleBackColor = true;
            publiceringsDatum.Click += publiceringsDatum_Click;
            // 
            // senareDatum
            // 
            senareDatum.Location = new Point(116, 341);
            senareDatum.Name = "senareDatum";
            senareDatum.Size = new Size(82, 27);
            senareDatum.TabIndex = 12;
            // 
            // tidigareDatum
            // 
            tidigareDatum.Location = new Point(116, 308);
            tidigareDatum.Name = "tidigareDatum";
            tidigareDatum.Size = new Size(82, 27);
            tidigareDatum.TabIndex = 11;
            // 
            // avsnittBeskrivning
            // 
            avsnittBeskrivning.Location = new Point(232, 63);
            avsnittBeskrivning.Name = "avsnittBeskrivning";
            avsnittBeskrivning.Size = new Size(250, 219);
            avsnittBeskrivning.TabIndex = 10;
            avsnittBeskrivning.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(beskrivningsBoxMinaSidor);
            tabPage2.Controls.Add(listaAvsnittMinaSidor);
            tabPage2.Controls.Add(listaPodcastMinaSidor);
            tabPage2.Controls.Add(sorteraKategorier2);
            tabPage2.Controls.Add(uppdateraPoddlistaMinaSidor);
            tabPage2.Controls.Add(raderapodd);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // beskrivningsBoxMinaSidor
            // 
            beskrivningsBoxMinaSidor.Location = new Point(423, 21);
            beskrivningsBoxMinaSidor.Name = "beskrivningsBoxMinaSidor";
            beskrivningsBoxMinaSidor.Size = new Size(187, 204);
            beskrivningsBoxMinaSidor.TabIndex = 21;
            beskrivningsBoxMinaSidor.Text = "";
            beskrivningsBoxMinaSidor.TextChanged += richTextBox1_TextChanged;
            // 
            // listaAvsnittMinaSidor
            // 
            listaAvsnittMinaSidor.FormattingEnabled = true;
            listaAvsnittMinaSidor.Location = new Point(210, 21);
            listaAvsnittMinaSidor.Name = "listaAvsnittMinaSidor";
            listaAvsnittMinaSidor.Size = new Size(179, 204);
            listaAvsnittMinaSidor.TabIndex = 20;
            listaAvsnittMinaSidor.SelectedIndexChanged += listaAvsnittMinaSidor_SelectedIndexChanged;
            // 
            // listaPodcastMinaSidor
            // 
            listaPodcastMinaSidor.FormattingEnabled = true;
            listaPodcastMinaSidor.Location = new Point(6, 21);
            listaPodcastMinaSidor.Name = "listaPodcastMinaSidor";
            listaPodcastMinaSidor.Size = new Size(179, 204);
            listaPodcastMinaSidor.TabIndex = 19;
            listaPodcastMinaSidor.SelectedIndexChanged += listaPodcastMinaSidor_SelectedIndexChanged;
            // 
            // sorteraKategorier2
            // 
            sorteraKategorier2.FormattingEnabled = true;
            sorteraKategorier2.Location = new Point(277, 343);
            sorteraKategorier2.Name = "sorteraKategorier2";
            sorteraKategorier2.Size = new Size(151, 28);
            sorteraKategorier2.TabIndex = 18;
            sorteraKategorier2.SelectedIndexChanged += sorteraKategorier2_SelectedIndexChanged;
            // 
            // uppdateraPoddlistaMinaSidor
            // 
            uppdateraPoddlistaMinaSidor.Location = new Point(14, 342);
            uppdateraPoddlistaMinaSidor.Name = "uppdateraPoddlistaMinaSidor";
            uppdateraPoddlistaMinaSidor.Size = new Size(94, 29);
            uppdateraPoddlistaMinaSidor.TabIndex = 17;
            uppdateraPoddlistaMinaSidor.Text = "uppdatPoddlista";
            uppdateraPoddlistaMinaSidor.UseVisualStyleBackColor = true;
            uppdateraPoddlistaMinaSidor.Click += uppdateraPoddlistaMinaSidor_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(redigeraKategoriKnapp);
            tabPage3.Controls.Add(redigeraKategori);
            tabPage3.Controls.Add(skapaKategoriText);
            tabPage3.Controls.Add(visaKategorier);
            tabPage3.Controls.Add(listaKategorier);
            tabPage3.Controls.Add(listaPoddarKategori);
            tabPage3.Controls.Add(skapanyKategori);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 414);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // skapaKategoriText
            // 
            skapaKategoriText.Location = new Point(659, 18);
            skapaKategoriText.Name = "skapaKategoriText";
            skapaKategoriText.Size = new Size(125, 27);
            skapaKategoriText.TabIndex = 18;
            // 
            // visaKategorier
            // 
            visaKategorier.Location = new Point(659, 326);
            visaKategorier.Name = "visaKategorier";
            visaKategorier.Size = new Size(94, 29);
            visaKategorier.TabIndex = 15;
            visaKategorier.Text = "button1";
            visaKategorier.UseVisualStyleBackColor = true;
            visaKategorier.Click += visaKategorier_Click;
            // 
            // listaKategorier
            // 
            listaKategorier.Location = new Point(510, 18);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(143, 337);
            listaKategorier.TabIndex = 14;
            listaKategorier.UseCompatibleStateImageBehavior = false;
            listaKategorier.SelectedIndexChanged += listaKategorier_SelectedIndexChanged;
            // 
            // listaPoddarKategori
            // 
            listaPoddarKategori.Location = new Point(18, 18);
            listaPoddarKategori.Name = "listaPoddarKategori";
            listaPoddarKategori.Size = new Size(143, 337);
            listaPoddarKategori.TabIndex = 13;
            listaPoddarKategori.UseCompatibleStateImageBehavior = false;
            listaPoddarKategori.SelectedIndexChanged += listaPoddarKategori_SelectedIndexChanged;
            // 
            // redigeraKategori
            // 
            redigeraKategori.Location = new Point(659, 82);
            redigeraKategori.Name = "redigeraKategori";
            redigeraKategori.Size = new Size(125, 27);
            redigeraKategori.TabIndex = 19;
            // 
            // redigeraKategoriKnapp
            // 
            redigeraKategoriKnapp.Location = new Point(659, 115);
            redigeraKategoriKnapp.Name = "redigeraKategoriKnapp";
            redigeraKategoriKnapp.Size = new Size(94, 29);
            redigeraKategoriKnapp.TabIndex = 20;
            redigeraKategoriKnapp.Text = "button1";
            redigeraKategoriKnapp.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(167, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(167, 52);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(167, 150);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(poddTabbar);
            Name = "Form1";
            Text = "Form1";
            poddTabbar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
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
        private ComboBox sorteraKategorier;
        private ComboBox sorteraKategorier2;
        private Button visaKategorier;
        private ListView listaKategorier;
        private ListView listaPoddarKategori;
        private ListBox listaAvsnittBox;
        private RichTextBox beskrivningsBoxMinaSidor;
        private ListBox listaAvsnittMinaSidor;
        private ListBox listaPodcastMinaSidor;
        private TextBox skapaKategoriText;
        private TextBox redigeraKategori;
        private ComboBox comboBox1;
        private Button redigeraKategoriKnapp;
        private ComboBox comboBox2;
        private Button button2;
        private Button button1;
    }
}
