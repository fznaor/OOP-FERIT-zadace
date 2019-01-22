namespace Z5
{
    partial class FormTV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewEpisodes = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSeasons = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewShows = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPremiered = new System.Windows.Forms.Label();
            this.labelPremieredTag = new System.Windows.Forms.Label();
            this.labelRuntimeTag = new System.Windows.Forms.Label();
            this.labelRuntime = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusTag = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelGenresTag = new System.Windows.Forms.Label();
            this.labelLanguageTag = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTypeTag = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameTag = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionTag = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxShowPic = new System.Windows.Forms.PictureBox();
            this.labelOfficialSiteTag = new System.Windows.Forms.Label();
            this.labelOfficialSite = new System.Windows.Forms.Label();
            this.labelNetworkTag = new System.Windows.Forms.Label();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.labelShowSearch = new System.Windows.Forms.Label();
            this.labelShowSelect = new System.Windows.Forms.Label();
            this.labelSeasonSelect = new System.Windows.Forms.Label();
            this.labelEpisodeSelect = new System.Windows.Forms.Label();
            this.labelSeasonList = new System.Windows.Forms.Label();
            this.labelEpisodeList = new System.Windows.Forms.Label();
            this.labelEpSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewEpisodes
            // 
            this.listViewEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewEpisodes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEpisodes.GridLines = true;
            this.listViewEpisodes.Location = new System.Drawing.Point(579, 467);
            this.listViewEpisodes.Name = "listViewEpisodes";
            this.listViewEpisodes.Size = new System.Drawing.Size(695, 266);
            this.listViewEpisodes.TabIndex = 43;
            this.listViewEpisodes.UseCompatibleStateImageBehavior = false;
            this.listViewEpisodes.View = System.Windows.Forms.View.Details;
            this.listViewEpisodes.Visible = false;
            this.listViewEpisodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewEpisodes_doubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "No.";
            this.columnHeader9.Width = 42;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 431;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Airdate";
            this.columnHeader11.Width = 112;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Runtime";
            this.columnHeader12.Width = 103;
            // 
            // listViewSeasons
            // 
            this.listViewSeasons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewSeasons.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSeasons.GridLines = true;
            this.listViewSeasons.Location = new System.Drawing.Point(12, 467);
            this.listViewSeasons.Name = "listViewSeasons";
            this.listViewSeasons.Size = new System.Drawing.Size(509, 266);
            this.listViewSeasons.TabIndex = 42;
            this.listViewSeasons.UseCompatibleStateImageBehavior = false;
            this.listViewSeasons.View = System.Windows.Forms.View.Details;
            this.listViewSeasons.Visible = false;
            this.listViewSeasons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSeasons_doubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No.";
            this.columnHeader2.Width = 38;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Episodes";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Premiere date";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Finale date";
            this.columnHeader7.Width = 119;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Network";
            this.columnHeader8.Width = 136;
            // 
            // listViewShows
            // 
            this.listViewShows.AllowColumnReorder = true;
            this.listViewShows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewShows.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewShows.GridLines = true;
            this.listViewShows.Location = new System.Drawing.Point(12, 68);
            this.listViewShows.Name = "listViewShows";
            this.listViewShows.Size = new System.Drawing.Size(509, 260);
            this.listViewShows.TabIndex = 41;
            this.listViewShows.UseCompatibleStateImageBehavior = false;
            this.listViewShows.View = System.Windows.Forms.View.Details;
            this.listViewShows.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewShows_doubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 258;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Premiered";
            this.columnHeader4.Width = 111;
            // 
            // labelPremiered
            // 
            this.labelPremiered.AutoSize = true;
            this.labelPremiered.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPremiered.Location = new System.Drawing.Point(645, 225);
            this.labelPremiered.Name = "labelPremiered";
            this.labelPremiered.Size = new System.Drawing.Size(85, 13);
            this.labelPremiered.TabIndex = 40;
            this.labelPremiered.Text = "labelPremiered";
            // 
            // labelPremieredTag
            // 
            this.labelPremieredTag.AutoSize = true;
            this.labelPremieredTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPremieredTag.Location = new System.Drawing.Point(576, 225);
            this.labelPremieredTag.Name = "labelPremieredTag";
            this.labelPremieredTag.Size = new System.Drawing.Size(63, 13);
            this.labelPremieredTag.TabIndex = 39;
            this.labelPremieredTag.Text = "Premiered:";
            // 
            // labelRuntimeTag
            // 
            this.labelRuntimeTag.AutoSize = true;
            this.labelRuntimeTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuntimeTag.Location = new System.Drawing.Point(576, 191);
            this.labelRuntimeTag.Name = "labelRuntimeTag";
            this.labelRuntimeTag.Size = new System.Drawing.Size(54, 13);
            this.labelRuntimeTag.TabIndex = 38;
            this.labelRuntimeTag.Text = "Runtime:";
            // 
            // labelRuntime
            // 
            this.labelRuntime.AutoSize = true;
            this.labelRuntime.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuntime.Location = new System.Drawing.Point(645, 191);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(76, 13);
            this.labelRuntime.TabIndex = 37;
            this.labelRuntime.Text = "labelRuntime";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(645, 157);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(64, 13);
            this.labelStatus.TabIndex = 36;
            this.labelStatus.Text = "labelStatus";
            // 
            // labelStatusTag
            // 
            this.labelStatusTag.AutoSize = true;
            this.labelStatusTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusTag.Location = new System.Drawing.Point(576, 157);
            this.labelStatusTag.Name = "labelStatusTag";
            this.labelStatusTag.Size = new System.Drawing.Size(42, 13);
            this.labelStatusTag.TabIndex = 35;
            this.labelStatusTag.Text = "Status:";
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenres.Location = new System.Drawing.Point(645, 126);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(68, 13);
            this.labelGenres.TabIndex = 34;
            this.labelGenres.Text = "labelGenres";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.Location = new System.Drawing.Point(645, 93);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(84, 13);
            this.labelLanguage.TabIndex = 33;
            this.labelLanguage.Text = "labelLanguage";
            // 
            // labelGenresTag
            // 
            this.labelGenresTag.AutoSize = true;
            this.labelGenresTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenresTag.Location = new System.Drawing.Point(576, 126);
            this.labelGenresTag.Name = "labelGenresTag";
            this.labelGenresTag.Size = new System.Drawing.Size(46, 13);
            this.labelGenresTag.TabIndex = 32;
            this.labelGenresTag.Text = "Genres:";
            // 
            // labelLanguageTag
            // 
            this.labelLanguageTag.AutoSize = true;
            this.labelLanguageTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguageTag.Location = new System.Drawing.Point(576, 93);
            this.labelLanguageTag.Name = "labelLanguageTag";
            this.labelLanguageTag.Size = new System.Drawing.Size(62, 13);
            this.labelLanguageTag.TabIndex = 31;
            this.labelLanguageTag.Text = "Language:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(645, 59);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 13);
            this.labelType.TabIndex = 30;
            this.labelType.Text = "labelType";
            // 
            // labelTypeTag
            // 
            this.labelTypeTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeTag.Location = new System.Drawing.Point(576, 59);
            this.labelTypeTag.Name = "labelTypeTag";
            this.labelTypeTag.Size = new System.Drawing.Size(35, 13);
            this.labelTypeTag.TabIndex = 29;
            this.labelTypeTag.Text = "Type:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(645, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 13);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "labelName";
            // 
            // labelNameTag
            // 
            this.labelNameTag.AutoSize = true;
            this.labelNameTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameTag.Location = new System.Drawing.Point(576, 26);
            this.labelNameTag.Name = "labelNameTag";
            this.labelNameTag.Size = new System.Drawing.Size(41, 13);
            this.labelNameTag.TabIndex = 27;
            this.labelNameTag.Text = "Name:";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(645, 331);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 13);
            this.labelDescription.TabIndex = 26;
            this.labelDescription.Text = "labelDescription";
            // 
            // labelDescriptionTag
            // 
            this.labelDescriptionTag.AutoSize = true;
            this.labelDescriptionTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionTag.Location = new System.Drawing.Point(576, 331);
            this.labelDescriptionTag.Name = "labelDescriptionTag";
            this.labelDescriptionTag.Size = new System.Drawing.Size(69, 13);
            this.labelDescriptionTag.TabIndex = 25;
            this.labelDescriptionTag.Text = "Description:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(446, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(394, 20);
            this.textBoxSearch.TabIndex = 23;
            // 
            // pictureBoxShowPic
            // 
            this.pictureBoxShowPic.Location = new System.Drawing.Point(1059, 26);
            this.pictureBoxShowPic.Name = "pictureBoxShowPic";
            this.pictureBoxShowPic.Size = new System.Drawing.Size(215, 221);
            this.pictureBoxShowPic.TabIndex = 44;
            this.pictureBoxShowPic.TabStop = false;
            // 
            // labelOfficialSiteTag
            // 
            this.labelOfficialSiteTag.AutoSize = true;
            this.labelOfficialSiteTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficialSiteTag.Location = new System.Drawing.Point(576, 262);
            this.labelOfficialSiteTag.Name = "labelOfficialSiteTag";
            this.labelOfficialSiteTag.Size = new System.Drawing.Size(69, 13);
            this.labelOfficialSiteTag.TabIndex = 45;
            this.labelOfficialSiteTag.Text = "Official site:";
            // 
            // labelOfficialSite
            // 
            this.labelOfficialSite.AutoSize = true;
            this.labelOfficialSite.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficialSite.Location = new System.Drawing.Point(645, 262);
            this.labelOfficialSite.Name = "labelOfficialSite";
            this.labelOfficialSite.Size = new System.Drawing.Size(88, 13);
            this.labelOfficialSite.TabIndex = 46;
            this.labelOfficialSite.Text = "labelOfficialSite";
            // 
            // labelNetworkTag
            // 
            this.labelNetworkTag.AutoSize = true;
            this.labelNetworkTag.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetworkTag.Location = new System.Drawing.Point(576, 297);
            this.labelNetworkTag.Name = "labelNetworkTag";
            this.labelNetworkTag.Size = new System.Drawing.Size(55, 13);
            this.labelNetworkTag.TabIndex = 47;
            this.labelNetworkTag.Text = "Network:";
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetwork.Location = new System.Drawing.Point(645, 297);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(77, 13);
            this.labelNetwork.TabIndex = 48;
            this.labelNetwork.Text = "labelNetwork";
            // 
            // labelShowSearch
            // 
            this.labelShowSearch.AutoSize = true;
            this.labelShowSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowSearch.Location = new System.Drawing.Point(9, 9);
            this.labelShowSearch.Name = "labelShowSearch";
            this.labelShowSearch.Size = new System.Drawing.Size(140, 16);
            this.labelShowSearch.TabIndex = 49;
            this.labelShowSearch.Text = "Search show by name";
            // 
            // labelShowSelect
            // 
            this.labelShowSelect.AutoSize = true;
            this.labelShowSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowSelect.Location = new System.Drawing.Point(12, 331);
            this.labelShowSelect.Name = "labelShowSelect";
            this.labelShowSelect.Size = new System.Drawing.Size(285, 16);
            this.labelShowSelect.TabIndex = 50;
            this.labelShowSelect.Text = "Double click show name to display its seasons";
            // 
            // labelSeasonSelect
            // 
            this.labelSeasonSelect.AutoSize = true;
            this.labelSeasonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeasonSelect.Location = new System.Drawing.Point(12, 736);
            this.labelSeasonSelect.Name = "labelSeasonSelect";
            this.labelSeasonSelect.Size = new System.Drawing.Size(315, 16);
            this.labelSeasonSelect.TabIndex = 51;
            this.labelSeasonSelect.Text = "Double click season number to display its episodes";
            this.labelSeasonSelect.Visible = false;
            // 
            // labelEpisodeSelect
            // 
            this.labelEpisodeSelect.AutoSize = true;
            this.labelEpisodeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpisodeSelect.Location = new System.Drawing.Point(579, 736);
            this.labelEpisodeSelect.Name = "labelEpisodeSelect";
            this.labelEpisodeSelect.Size = new System.Drawing.Size(317, 16);
            this.labelEpisodeSelect.TabIndex = 52;
            this.labelEpisodeSelect.Text = "Double click episode number to display its synopsis";
            this.labelEpisodeSelect.Visible = false;
            // 
            // labelSeasonList
            // 
            this.labelSeasonList.AutoSize = true;
            this.labelSeasonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeasonList.Location = new System.Drawing.Point(9, 446);
            this.labelSeasonList.Name = "labelSeasonList";
            this.labelSeasonList.Size = new System.Drawing.Size(74, 18);
            this.labelSeasonList.TabIndex = 53;
            this.labelSeasonList.Text = "Seasons";
            this.labelSeasonList.Visible = false;
            // 
            // labelEpisodeList
            // 
            this.labelEpisodeList.AutoSize = true;
            this.labelEpisodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpisodeList.Location = new System.Drawing.Point(576, 446);
            this.labelEpisodeList.Name = "labelEpisodeList";
            this.labelEpisodeList.Size = new System.Drawing.Size(78, 18);
            this.labelEpisodeList.TabIndex = 54;
            this.labelEpisodeList.Text = "Episodes";
            this.labelEpisodeList.Visible = false;
            // 
            // labelEpSummary
            // 
            this.labelEpSummary.AutoSize = true;
            this.labelEpSummary.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpSummary.Location = new System.Drawing.Point(576, 776);
            this.labelEpSummary.Name = "labelEpSummary";
            this.labelEpSummary.Size = new System.Drawing.Size(94, 13);
            this.labelEpSummary.TabIndex = 55;
            this.labelEpSummary.Text = "labelEpSummary";
            this.labelEpSummary.Visible = false;
            // 
            // FormTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 878);
            this.Controls.Add(this.labelEpSummary);
            this.Controls.Add(this.labelEpisodeList);
            this.Controls.Add(this.labelSeasonList);
            this.Controls.Add(this.labelEpisodeSelect);
            this.Controls.Add(this.labelSeasonSelect);
            this.Controls.Add(this.labelShowSelect);
            this.Controls.Add(this.labelShowSearch);
            this.Controls.Add(this.labelNetwork);
            this.Controls.Add(this.labelNetworkTag);
            this.Controls.Add(this.labelOfficialSite);
            this.Controls.Add(this.labelOfficialSiteTag);
            this.Controls.Add(this.pictureBoxShowPic);
            this.Controls.Add(this.listViewEpisodes);
            this.Controls.Add(this.listViewSeasons);
            this.Controls.Add(this.listViewShows);
            this.Controls.Add(this.labelPremiered);
            this.Controls.Add(this.labelPremieredTag);
            this.Controls.Add(this.labelRuntimeTag);
            this.Controls.Add(this.labelRuntime);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelStatusTag);
            this.Controls.Add(this.labelGenres);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelGenresTag);
            this.Controls.Add(this.labelLanguageTag);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTypeTag);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNameTag);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDescriptionTag);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "FormTV";
            this.Text = "TV search";
            this.Load += new System.EventHandler(this.FormTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEpisodes;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView listViewSeasons;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewShows;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelPremiered;
        private System.Windows.Forms.Label labelPremieredTag;
        private System.Windows.Forms.Label labelRuntimeTag;
        private System.Windows.Forms.Label labelRuntime;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusTag;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelGenresTag;
        private System.Windows.Forms.Label labelLanguageTag;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTypeTag;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameTag;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDescriptionTag;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxShowPic;
        private System.Windows.Forms.Label labelOfficialSiteTag;
        private System.Windows.Forms.Label labelOfficialSite;
        private System.Windows.Forms.Label labelNetworkTag;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.Label labelShowSearch;
        private System.Windows.Forms.Label labelShowSelect;
        private System.Windows.Forms.Label labelSeasonSelect;
        private System.Windows.Forms.Label labelEpisodeSelect;
        private System.Windows.Forms.Label labelSeasonList;
        private System.Windows.Forms.Label labelEpisodeList;
        private System.Windows.Forms.Label labelEpSummary;
    }
}

