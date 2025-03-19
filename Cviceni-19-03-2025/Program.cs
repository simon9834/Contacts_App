using Cviceni_19_03_2025.Command_Classes;
    List<Contact> contacts = new List<Contact>();
ICommand showContactsCommand = new ShowContacts(contacts);
ICommand addContactCommand = new AddContact(contacts);
ICommand deleteContactCommand = new DeleteContact(contacts);

Menu menu = new Menu();
menu.add(new MenuItem("Show Contacts list", showContactsCommand));
menu.add(new MenuItem("Add new contact", addContactCommand));
menu.add(new MenuItem("Delete a contact", deleteContactCommand));
menu.UserInpt();
