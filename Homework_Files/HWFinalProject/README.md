Final Project as a group


Your project must satisfy the following requirements:
1. Create three classes: Pool, Temperature, and Location.
2. A swimming pool shall have an object of “Temperature” and an object of “Location” as data
members. (“Compositionally” speaking: A pool has-a temperature, and a pool has-a location)
3. A temperature has “degree” and “scale”.
4. A location is defined by (x, y); hence a location has an ‘x’ value and a ‘y’ value.
5. Provide ToString method for all three classes.
6. Provide other member methods for each of the classes properly . For example, a
FindDistance method to find the distance between pools.
7. All methods shall be public.
8. The Pool class shall have a static data member ‘Count’ The driver program shall print out
the static member count before any pool object is created, and also after each pool is
instantiated.
9. A maintenance crew can set the temperature for each pool within the range of 98 oF and
104 oF.
Note: generate a random number between [98, 104].
10. A maintenance person will go through all seven pools and set the temperatures. The person
starts from location (0,0), and will go to the nearest pool after she/he finishes the job. The
process continues until all the pools are visited. Each pool can only be visited once.
Your driver program determines and displays the route she/he takes to visit all the pools,
such as :
(0,0) >> B with temperature at 99 degree F >> C with temperature at 103 degree
F >> ... ....
