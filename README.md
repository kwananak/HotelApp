# HotelAppSolution

A light hotel management app to showcase my knowledge of SQL queries and C# programming.

When you start up the app, you'll be requested to entered valid credentials checked against a local SQL server.
![loginpage](https://user-images.githubusercontent.com/100873735/225089066-7ba5860b-6b4f-4de9-ab70-3f9ba57d81af.png)

If you enter invalid informations, you'll be alerted and remain on the login page.
![loignpageinvcred](https://user-images.githubusercontent.com/100873735/225089912-d5c05266-c3b5-4d1e-a543-29bcd80f35e2.png)

With valid credentials, the main page will open where you'll be able to select from available tabs depending on your role (i.e. Boss, Desk or Cleaning).
Here is the main page for admin rights (which are the same as Boss).
![mainpage](https://user-images.githubusercontent.com/100873735/225090534-874c20c8-4ae9-43ec-b437-d9e325539c36.png)

For comparison, here's the main page for desk clerks.
![deskmainpage](https://user-images.githubusercontent.com/100873735/225090751-abfe398b-a97d-4c2e-b381-42faef2e028f.png)

And for the cleaning staff.
![cleaningmainpage](https://user-images.githubusercontent.com/100873735/225090804-3c3f7041-6a22-47f6-871f-b5faa3b99c6f.png)

By clicking any tab, it will open the appropriate panel. Let's see the reservation view tab for admin with all options available.
![adminreservationsview](https://user-images.githubusercontent.com/100873735/225091458-6b29936a-029c-4ce0-9e0a-b4520b9b109b.png)

Now, let's click on the update button. You'll get an option to enter a reservation ID.
![adminreservationsupdate](https://user-images.githubusercontent.com/100873735/225091730-39c28e52-fce5-45ce-8c8f-d846b62348ae.png)

By entering the reservation ID number 3 you'll retrieve corresponding data.
![adminreservationsupdateget](https://user-images.githubusercontent.com/100873735/225091938-c8607aab-66ff-435d-84eb-4fe4a74b1db2.png)

Let's switch the check out date to the 19th and click the confirm button. The reservation is now updated.
![adminreservationdatechanged](https://user-images.githubusercontent.com/100873735/225092666-b3340b96-f394-46ea-b748-e57009b8e896.png)

We can now look at the tasks tab. There you'll find check in, check out and cleaning tasks to be done. You can search by date. Admin and Boss roles can see all tasks, but desk and cleaning staff only have access to their respective tasks. 
Here's the desk staff view.
![desktasksview](https://user-images.githubusercontent.com/100873735/225093500-f867376d-0287-4b4d-9af5-c9df01bba672.png)

And the cleaning staff view with the same parameters.
![cleaningtasksview](https://user-images.githubusercontent.com/100873735/225093608-0eeefe9e-1c70-480d-b63c-ded1eda66d0b.png)

To complete a task, enter the reservation ID. It will retrieve all available infos. The confirm button will adapt to the selected task. Here in the example, a desk staff in about to complete a check out for reservation ID 3. It will automatically update the reservation and the room infos with the appropriate employee ID.
![desktaskscomplete](https://user-images.githubusercontent.com/100873735/225094113-58cdeeb5-4f52-4e36-a3a3-870f215707f9.png)

As a comparison, here's the admin panel for completing task. They can set which task they want completed and enter the employee ID related to who completed the task.
![admintaskscomplete](https://user-images.githubusercontent.com/100873735/225094351-4fb10cc6-f10a-4a9a-84e9-e431838b485f.png)

Panels are pretty standardized, here's a view of the rooms panel for admin as an other example.
![adminroomsview](https://user-images.githubusercontent.com/100873735/225094938-cc8847ba-5597-4237-b5ad-5c0d0a2b1916.png)

The SQL database diagram looks like this.

![hotelappdiagram](https://user-images.githubusercontent.com/100873735/225095046-570c8fee-4e0c-413c-91d4-2d337731f41c.png)

And the design for each table is as follows:

- employees table

![employeesdesign](https://user-images.githubusercontent.com/100873735/225095198-7d5be157-d524-40cf-b73d-38e32b61e281.png)

- guests table

![guestsdesign](https://user-images.githubusercontent.com/100873735/225095394-1b0e8fba-d85a-4afb-a5e6-69900541a413.png)

- reservations table

![reservationsdesign](https://user-images.githubusercontent.com/100873735/225095450-e49fab53-7c12-4420-8e96-3e683a3f5757.png)

- rooms table

![roomsdesign](https://user-images.githubusercontent.com/100873735/225095510-dadae017-0ed7-4b31-9139-f541737c814b.png)



project made with C#, .net, visual studio and SQL managed with SSMS
