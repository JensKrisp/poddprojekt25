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
            listaPoddar = new ListView();
            uppdateraPoddFlöde = new Button();
            listaAvsnitt = new ListView();
            URL = new TextBox();
            sparaPodd = new Button();
            raderapodd = new Button();
            skapanyKategori = new Button();
            redigeraKategori = new Button();
            raderaKategori = new Button();
            poddTabbar = new TabControl();
            tabPage1 = new TabPage();
            sorteraKategorier = new ComboBox();
            publiceringsDatum = new Button();
            senareDatum = new DateTimePicker();
            tidigareDatum = new DateTimePicker();
            avsnittBeskrivning = new RichTextBox();
            tabPage2 = new TabPage();
            sorteraKategorier2 = new ComboBox();
            uppdateraPoddlistaMinaSidor = new Button();
            avsnittBeskrivningMinaSidor = new RichTextBox();
            listaAvsnittMinaSidor = new ListView();
            listaPoddarMinaSidor = new ListView();
            tabPage3 = new TabPage();
            visaKategorier = new Button();
            listaKategorier = new ListView();
            listaPoddarKategori = new ListView();
            poddTabbar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // listaPoddar
            // 
            listaPoddar.Location = new Point(6, 62);
            listaPoddar.Name = "listaPoddar";
            listaPoddar.Size = new Size(94, 210);
            listaPoddar.TabIndex = 0;
            listaPoddar.UseCompatibleStateImageBehavior = false;
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
            // listaAvsnitt
            // 
            listaAvsnitt.Location = new Point(116, 62);
            listaAvsnitt.Name = "listaAvsnitt";
            listaAvsnitt.Size = new Size(128, 210);
            listaAvsnitt.TabIndex = 3;
            listaAvsnitt.UseCompatibleStateImageBehavior = false;
            listaAvsnitt.SelectedIndexChanged += listaAvsnitt_SelectedIndexChanged;
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
            skapanyKategori.Location = new Point(358, 18);
            skapanyKategori.Name = "skapanyKategori";
            skapanyKategori.Size = new Size(94, 29);
            skapanyKategori.TabIndex = 10;
            skapanyKategori.Text = "skapaNyKategori";
            skapanyKategori.UseVisualStyleBackColor = true;
            skapanyKategori.Click += skapanyKategori_Click;
            // 
            // redigeraKategori
            // 
            redigeraKategori.Location = new Point(358, 65);
            redigeraKategori.Name = "redigeraKategori";
            redigeraKategori.Size = new Size(94, 29);
            redigeraKategori.TabIndex = 11;
            redigeraKategori.Text = "redigeraKategori";
            redigeraKategori.UseVisualStyleBackColor = true;
            // 
            // raderaKategori
            // 
            raderaKategori.Location = new Point(358, 124);
            raderaKategori.Name = "raderaKategori";
            raderaKategori.Size = new Size(94, 29);
            raderaKategori.TabIndex = 12;
            raderaKategori.Text = "raderaKategori";
            raderaKategori.UseVisualStyleBackColor = true;
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
            tabPage1.Controls.Add(sorteraKategorier);
            tabPage1.Controls.Add(publiceringsDatum);
            tabPage1.Controls.Add(senareDatum);
            tabPage1.Controls.Add(tidigareDatum);
            tabPage1.Controls.Add(avsnittBeskrivning);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(listaPoddar);
            tabPage1.Controls.Add(listaAvsnitt);
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
            avsnittBeskrivning.Location = new Point(260, 62);
            avsnittBeskrivning.Name = "avsnittBeskrivning";
            avsnittBeskrivning.Size = new Size(129, 210);
            avsnittBeskrivning.TabIndex = 10;
            avsnittBeskrivning.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sorteraKategorier2);
            tabPage2.Controls.Add(uppdateraPoddlistaMinaSidor);
            tabPage2.Controls.Add(avsnittBeskrivningMinaSidor);
            tabPage2.Controls.Add(listaAvsnittMinaSidor);
            tabPage2.Controls.Add(listaPoddarMinaSidor);
            tabPage2.Controls.Add(raderapodd);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sorteraKategorier2
            // 
            sorteraKategorier2.FormattingEnabled = true;
            sorteraKategorier2.Location = new Point(277, 343);
            sorteraKategorier2.Name = "sorteraKategorier2";
            sorteraKategorier2.Size = new Size(151, 28);
            sorteraKategorier2.TabIndex = 18;
            // 
            // uppdateraPoddlistaMinaSidor
            // 
            uppdateraPoddlistaMinaSidor.Location = new Point(14, 342);
            uppdateraPoddlistaMinaSidor.Name = "uppdateraPoddlistaMinaSidor";
            uppdateraPoddlistaMinaSidor.Size = new Size(94, 29);
            uppdateraPoddlistaMinaSidor.TabIndex = 17;
            uppdateraPoddlistaMinaSidor.Text = "uppdatPoddlista";
            uppdateraPoddlistaMinaSidor.UseVisualStyleBackColor = true;
            // 
            // avsnittBeskrivningMinaSidor
            // 
            avsnittBeskrivningMinaSidor.Location = new Point(328, 39);
            avsnittBeskrivningMinaSidor.Name = "avsnittBeskrivningMinaSidor";
            avsnittBeskrivningMinaSidor.Size = new Size(125, 256);
            avsnittBeskrivningMinaSidor.TabIndex = 16;
            avsnittBeskrivningMinaSidor.Text = "";
            // 
            // listaAvsnittMinaSidor
            // 
            listaAvsnittMinaSidor.Location = new Point(171, 39);
            listaAvsnittMinaSidor.Name = "listaAvsnittMinaSidor";
            listaAvsnittMinaSidor.Size = new Size(151, 256);
            listaAvsnittMinaSidor.TabIndex = 15;
            listaAvsnittMinaSidor.UseCompatibleStateImageBehavior = false;
            // 
            // listaPoddarMinaSidor
            // 
            listaPoddarMinaSidor.Location = new Point(14, 39);
            listaPoddarMinaSidor.Name = "listaPoddarMinaSidor";
            listaPoddarMinaSidor.Size = new Size(151, 256);
            listaPoddarMinaSidor.TabIndex = 14;
            listaPoddarMinaSidor.UseCompatibleStateImageBehavior = false;
            listaPoddarMinaSidor.SelectedIndexChanged += listaPoddarMinaSidor_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(visaKategorier);
            tabPage3.Controls.Add(listaKategorier);
            tabPage3.Controls.Add(listaPoddarKategori);
            tabPage3.Controls.Add(skapanyKategori);
            tabPage3.Controls.Add(redigeraKategori);
            tabPage3.Controls.Add(raderaKategori);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 414);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // visaKategorier
            // 
            visaKategorier.Location = new Point(333, 326);
            visaKategorier.Name = "visaKategorier";
            visaKategorier.Size = new Size(94, 29);
            visaKategorier.TabIndex = 15;
            visaKategorier.Text = "button1";
            visaKategorier.UseVisualStyleBackColor = true;
            visaKategorier.Click += visaKategorier_Click;
            // 
            // listaKategorier
            // 
            listaKategorier.Location = new Point(184, 18);
            listaKategorier.Name = "listaKategorier";
            listaKategorier.Size = new Size(143, 337);
            listaKategorier.TabIndex = 14;
            listaKategorier.UseCompatibleStateImageBehavior = false;
            // 
            // listaPoddarKategori
            // 
            listaPoddarKategori.Location = new Point(18, 18);
            listaPoddarKategori.Name = "listaPoddarKategori";
            listaPoddarKategori.Size = new Size(143, 337);
            listaPoddarKategori.TabIndex = 13;
            listaPoddarKategori.UseCompatibleStateImageBehavior = false;
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
            ResumeLayout(false);
        }

        #endregion

        private ListView listaPoddar;
        private Button uppdateraPoddFlöde;
        private ListView listaAvsnitt;
        private TextBox URL;
        private Button sparaPodd;
        private Button raderapodd;
        private Button skapanyKategori;
        private Button redigeraKategori;
        private Button raderaKategori;
        private TabControl poddTabbar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private RichTextBox avsnittBeskrivning;
        private RichTextBox avsnittBeskrivningMinaSidor;
        private ListView listaAvsnittMinaSidor;
        private ListView listaPoddarMinaSidor;
        private Button uppdateraPoddlistaMinaSidor;
        private DateTimePicker senareDatum;
        private DateTimePicker tidigareDatum;
        private Button publiceringsDatum;
        private ComboBox sorteraKategorier;
        private ComboBox sorteraKategorier2;
        private Button visaKategorier;
        private ListView listaKategorier;
        private ListView listaPoddarKategori;
    }
}
