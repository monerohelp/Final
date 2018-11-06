# Final


Write the code to maintain a list of student records. The flow of your program should be to read all student records from a file, do stuff with the records (e.g., add, update, look up, etc.), then write the possibly new information back to the file before exiting. A student record will consist of a name, address, ID (7 digits and ID > 1000000), list of phone numbers, and a list of courses completed.

A name object will have 3 parts, first, middle, and last. Restrictions on valid characters and other fields are optional.

An address will consist of street number, street name, city, state (2 characters) and zip code. Zip plus 4 is optional.

A phone number will consist of area code, exchange, extension and type. For instance, with the number 216- 687-2000, 216 is the area code, 687 is the exchange and 2000 is the extension. I'll leave the type field for you to define.
A course will consist of a department name (3 characters), number, semester, year, credit hours and grade.
Fields in the name, address, phone number and course object will need the appropriate set and get routines. These objects also need equals, compareto and tostring methods. 

The student object has set and get routines for all data. The student object also methods to return the student's GPA, number of hour attempted, number of hours completed (assume only C- and higher count toward graduation). equals and compareto in the student object are dependent only on the ID field and the tostring only returns their name and ID.

Back to the program. After reading in the student records from the file, the program asks the end user to add, update or look up information until the end user is done. When done the program write the information back into the file. Note there are only to interactions with the file, initially reading in all the students records and at the end writing all the student records back to the file.

Using a GUI will greatly help in adding or updating a student record, however it is not required. When looking up information of a student, simply display all information including the calculated methods, hours attempted, hours earned and gpa. Optionally you might want a few ways to display a student's information - everything, contact information only, school information only, or short school info only (no individual course info).
