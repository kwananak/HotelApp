# HotelAppSolution

A light hotel management app to showcase my knowledge level of SQL queries and C# programming.

When you start up the app, you'll be requested to enter valid credentials checked against a local SQL server.
![loginpage](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/loginpage.png)

If you enter invalid informations, you'll be alerted and remain on the login page.
![loignpageinvcred](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/loignpageinvcred.png)

With valid credentials, the main page will open where you'll be able to select from available tabs depending on your role (i.e. Boss, Desk or Cleaning).
Here is the main page for admin rights (which are the same as Boss).
![mainpage](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/mainpage.png)

For comparison, here's the main page for desk clerks.
![deskmainpage](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/deskmainpage.png)

And for the cleaning staff.
![cleaningmainpage](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/cleaningmainpage.png)

By clicking any tab, it will open the appropriate panel. Let's see the reservation view tab for admin with all options available.
![adminreservationsview](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/adminreservationsview.png)

Now, let's click on the update button. You'll get an option to enter a reservation ID.
![adminreservationsupdate](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/adminreservationsupdate.png)

By entering the reservation ID number 3 you'll retrieve corresponding data.
![adminreservationsupdateget](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/adminreservationsupdateget.png)

Let's switch the check out date to the 19th and click the confirm button. The reservation is now updated.
![adminreservationdatechanged](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/adminreservationdatechanged.png)

We can now look at the tasks tab. There you'll find check in, check out and cleaning tasks to be done. You can search by date. Admin and Boss roles can see all tasks, but desk and cleaning staff only have access to their respective tasks. 
Here's the desk staff view.
![desktasksview](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/desktasksview.png)

And the cleaning staff view with the same parameters.
![cleaningtasksview](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/cleaningtasksview.png)

To complete a task, enter the reservation ID. It will retrieve all available infos. The confirm button will adapt to the selected task. Here in the example, a desk staff is about to complete a check out for reservation ID 3. It will automatically update the reservation and the room infos with the appropriate employee ID.
![desktaskscomplete](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/desktaskscomplete.png)

As a comparison, here's the admin panel for completing task. They can set which task they want completed and enter the employee ID related to who completed the task.
![admintaskscomplete](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/admintaskscomplete.png)

Panels are pretty standardized, here's a view of the rooms panel for admin as an other example.
![adminroomsview](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/adminroomsview.png)

The SQL database diagram looks like this:

![hotelappdiagram](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/hotelappdiagram.png)

And the design for each table is as follows:

- employees table

![employeesdesign](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/employeesdesign.png)

- guests table

![guestsdesign](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/guestsdesign.png)

- reservations table

![reservationsdesign](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/reservationsdesign.png)

- rooms table

![roomsdesign](https://github.com/kwananak/HotelApp/blob/master/HotelApp/ReadMeImages/roomsdesign.png)



project made with C#, visual studio and SQL managed with SSMS
