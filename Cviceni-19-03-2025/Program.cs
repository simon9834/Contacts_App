using Cviceni_19_03_2025.Command_Classes;
    List<Contact> contacts = new List<Contact>();
ICommand showContactsCommand = new 
ICommand addContactCommand = new AddContactCommand(contacts);
ICommand deleteContactCommand = new DeleteContactCommand(contacts);

Menu menu = new Menu();
menu.AddMenuItem(new MenuItem("Zobrazit seznam kontaktů", showContactsCommand));
menu.AddMenuItem(new MenuItem("Přidat nový kontakt", addContactCommand));
menu.AddMenuItem(new MenuItem("Smazat kontakt", deleteContactCommand));

menu.HandleUserInput();
