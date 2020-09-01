# Optional Opgave 1.2 - RealEstateApp projektet med Repos og IoC haves - UI laves
Her kan branchen 1.2.EmptyUIpages hentes fra GitHub. Der er allerede lavet Repository, IoC, Services samt tomme pages med MasterDetail navigation.

Gennemgå koden som allerede er lavet og vær sikker på at du forstå det hele.

Dernæst kan du kontrollere om der kan hentes 5 Property-objekter i PropertyListPage .

### PropertyListPage

PropertyListPage er allerede oprettet. PropertyListPage.xaml.cs indeholder en property kaldet PropertiesCollection, som indeholder objekter af typen PropertyListItem og som der kan bindes til når alle husene skal vises. Constructoren får fat i et objekt af MockRepository ved at lave  Resolve af IRepository. Derefter hentes alle Property-objekterne vha. GetProperties() og BindingContext kan sætte op. Start med at få det til at lykkedes, inden du går videre med xaml-koden.

Nu skal View'et laves. Begynd med at lave en skitse på papir af DataTemplaten med angivelse af hvilke properties der indeholder data.

Der benyttes Data Binding overalt.

Følgende skal du kun lave hvis du har tid til det: De små ikoner, der svarer til Beds, Baths og Parking er lavet med Font Awesome, se [vejledningen her](https://github.com/EgonRasmussen/IconFontDemo).



### PropertyDetailPage
Dens constructor skal kunne tage imod et Property objekt, som der bliver valgt i PropertyListPage. Få parameteroverførelsen til at virke, inden du går videre.

Når du har Property objektet, kan du også hente det aktuelle AgentId ved at slå op i Repository. Nu bør du have to properties, Property og Agent, som du kan binde til View'et.



### AddEditPropertyPage
Denne page kan man komme til både fra Add | PropertyListPage og fra Edit | PropertyDetailPage.  Kommer vi fra Edit, skal der kunne tages imod et Property objekt i constructoren. Om der er en parameter med eller ej kan benyttes til at styre Title, som enten skal være "Add Property" eller "Edit Property".

Man kan også lave Save-eventhandleren og i første omgang få navigationen til at gå tilbage til rod-siden.

Nu kan View'et laves med binding til Property og Agent.

Hvis du har overskud til det, bør der laves noget validering af brugerinput.

### UI

| ![Properties List](images/PropertiesList.png) PropertyListPage | ![Detail View](images/DetailView.png) PropertyDetailPage | ![Edit View](images/EditView.png) AddEditPage (EDIT) |  
|---|---|---|
|---|---|---|
| ![Add](images/Add.png) AddEditPage (ADD) | ![Flyout Menu](images/FlyoutMenu.png) MenuPage | ![About](images/About.png) AboutPage |  
|   |   |   |  
|   |   |   | 