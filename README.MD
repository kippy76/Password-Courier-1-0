##Password Courier V 1.0
#Visual Studio 2010 Project

I'm involved in a project at the moment where password access will be granted for staff and public use. It struck me that delivery of passwords via e-mail is fraught with issues, and wondered if there may be a better way to deliver passwords to clients that need regular passwords delivered to them.

Recent work with encryption gave me an idea. A small, e-mail sized application that could be downloaded and run to provide the password in question. By allocating clients a secure 'salt' code, the program could accept the clients salt code, plus a unique key for each password. The client's salt code would never be emailed, only the unique key for the requested password. By running the application and supplying the required key, the decrypted password is displayed on the client's machine.

Of course, such security relies on the client being provided a salt, probably verbally to avoid interception. In this way, interception of the email would only give the interceptor access to the encrypted password and the algorithm used. Without the salt code, which is securely held at the recipients location, it proves very difficult to gain access to the password.

Encryption aficionados will recognise the paradigm of symmetric key encryption, but I developed this app for clients that lack the technical expertise, and can simply use an application with the most minimal of interfaces. So, I kicked up a version 1 proof of concept which I have called 'Password Courier'. Plenty notes in the source code as to how it is to be used.

Basically, generate a unique salt for the client, and keep a note for future. For each new password, run the program in development mode, enter the salt, click on generate and you get an encrypted string. Code this into the program, turn the boolean flag for deploy to true, and compile. The resultant program can then be issued to the client, and they can simply be told to enter their code as usual and the decrypted password will appear!

Simple, handy and an interesting example to play about with. This application could be modified for more secure and complex salts as well as alternate encryption algorithms. Have fun with it.

#Chris Walker.
#cwalker.me.uk
#chris@cwalker.me.uk