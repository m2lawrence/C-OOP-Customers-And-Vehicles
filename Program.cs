//Michael Lawrence BSc (HONS)
using System;

namespace CSharpOOP
{
    class Customer  //Object Customer, with return Details method. 
    {
        //protecting variables in your class against "invalid conditions (-1) by making them private.
        private int CustomerID0, DateOfBirth0;
        private String Forename0, Surname0; //set the variables. private member access modifier.

        //Set methods.
        public void SetCustDetails(int CustomerID1, string Forename1, string Surname1, int DateOfBirth1) //method.
        {
            this.CustomerID0 = CustomerID1;
            this.Forename0 = Forename1;
            this.Surname0 = Surname1;
            this.DateOfBirth0 = DateOfBirth1;
        }

        //Get methods.
        public int GetCustomerID()
        {
            return this.CustomerID0;
        }

        public string GetForename()
        {
            return this.Forename0;
        }

        public string GetSurname()
        {
            return this.Surname0;
        }

        public int DateOfBirth()
        {
            return this.DateOfBirth0;
        }
    }
    //------------------------------------------------


    class Vehicle  //Object Vehicle. 
    {
        private int ID0, RegistrationDate0, EngineSize0, Owner0;
        private String Manufacture0, Model0, RegistrationNumber0, InteriorColourCarOnly0, HasHelmetStoreageMotorCyclesOnly0, VehicleType0; //set the variables. Public member access modifier.

        //Set methods.
        public void SetVehicleDetails(int ID1, string Manufacture1, string Model1, string RegistrationNumber1, int RegistrationDate1, int EngineSize1, int Owner1, string InteriorColourCarOnly1, string HasHelmetStoreageMotorCyclesOnly1, string VehicleType1)
        {
            this.ID0 = ID1;
            this.Manufacture0 = Manufacture1;
            this.Model0 = Model1;
            this.RegistrationNumber0 = RegistrationNumber1;
            this.RegistrationDate0 = RegistrationDate1;
            this.EngineSize0 = EngineSize1;
            this.Owner0 = Owner1;
            this.InteriorColourCarOnly0 = InteriorColourCarOnly1;
            this.HasHelmetStoreageMotorCyclesOnly0 = HasHelmetStoreageMotorCyclesOnly1;
            this.VehicleType0 = VehicleType1;
        }

        //Get methods.
        public int GetID()
        {
            return this.ID0;
        }

        public string GetManufacture()
        {
            return this.Manufacture0;
        }

        public string GetModel()
        {
            return this.Model0;
        }

        public string GetRegistrationNumber()
        {
            return this.RegistrationNumber0;
        }

        public int GetRegistrationDate()
        {
            return this.RegistrationDate0;
        }

        public int GetEngineSize()
        {
            return this.EngineSize0;
        }

        public int GetOwner()
        {
            return this.Owner0;
        }

        public string GetInteriorColourCarOnly()
        {
            return this.InteriorColourCarOnly0;
        }

        public string GetHasHelmetStoreageMotorCyclesOnly()
        {
            return this.HasHelmetStoreageMotorCyclesOnly0;
        }

        public string GetVehicleType()
        {
            return this.VehicleType0;
        }
    }
    //------------------------------------------------


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Michael Lawrence BSc (HONS) ***\n"); //me.

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("*** All vehicles with their owners. ***\n");
            //=============== 1 row in table =======================
            //Build new object.
            Customer Customer1 = new Customer();
            //Insert details.
            Customer1.SetCustDetails(1, "Joe", "Bloggs", 16041997);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer1.GetCustomerID(), Customer1.GetForename(), Customer1.GetSurname(), Customer1.DateOfBirth()); //write to screen
                              
            //-----------------------------
            //Build new object.
            Vehicle Vehicle1 = new Vehicle();
            //Insert details.
            Vehicle1.SetVehicleDetails(1, "Renault", "Clio", "BJ07 YUK", 01012000, 1290, 1, "Cream", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle1.GetID(), Vehicle1.GetManufacture(), Vehicle1.GetModel(), Vehicle1.GetRegistrationNumber(), Vehicle1.GetRegistrationDate(), Vehicle1.GetEngineSize(), Vehicle1.GetOwner(), Vehicle1.GetInteriorColourCarOnly(), Vehicle1.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle1.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------

            //=============== 2 row in table =======================
            //Build new object.
            Customer Customer2 = new Customer();
            //Insert details.
            Customer2.SetCustDetails(1, "Joe", "Bloggs", 16041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer2.GetCustomerID(), Customer2.GetForename(), Customer2.GetSurname(), Customer2.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle2 = new Vehicle();
            //Insert details.
            Vehicle2.SetVehicleDetails(7, "Renault", "Twingo", "BJ07 QAC", 02012018, 1190, 1, "Grey", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle2.GetID(), Vehicle2.GetManufacture(), Vehicle2.GetModel(), Vehicle2.GetRegistrationNumber(), Vehicle2.GetRegistrationDate(), Vehicle2.GetEngineSize(), Vehicle2.GetOwner(), Vehicle2.GetInteriorColourCarOnly(), Vehicle2.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle2.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------


            //=============== 3 row in table =======================
            //Build new object.
            Customer Customer3 = new Customer();
            //Insert details.
            Customer3.SetCustDetails(2, "Jane", "Doe", 17041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer3.GetCustomerID(), Customer3.GetForename(), Customer3.GetSurname(), Customer3.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle3 = new Vehicle();
            //Insert details.
            Vehicle3.SetVehicleDetails(2, "Ford", "Fiesta", "BT58 OKJ", 03012018, 1190, 1, "Black", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle3.GetID(), Vehicle3.GetManufacture(), Vehicle3.GetModel(), Vehicle3.GetRegistrationNumber(), Vehicle3.GetRegistrationDate(), Vehicle3.GetEngineSize(), Vehicle3.GetOwner(), Vehicle3.GetInteriorColourCarOnly(), Vehicle3.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle3.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------


            //=============== 4 row in table =======================
            //Build new object.
            Customer Customer4 = new Customer();
            //Insert details.
            Customer4.SetCustDetails(3, "Bob", "Smith", 18041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer4.GetCustomerID(), Customer4.GetForename(), Customer4.GetSurname(), Customer4.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle4 = new Vehicle();
            //Insert details.
            Vehicle4.SetVehicleDetails(3, "Peugeot", "108", "BJ53 WYR", 04012018, 987, 3, "Grey", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle4.GetID(), Vehicle4.GetManufacture(), Vehicle4.GetModel(), Vehicle4.GetRegistrationNumber(), Vehicle4.GetRegistrationDate(), Vehicle4.GetEngineSize(), Vehicle4.GetOwner(), Vehicle4.GetInteriorColourCarOnly(), Vehicle4.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle4.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------


            //=============== 5 row in table =======================
            //Build new object.
            Customer Customer5 = new Customer();
            //Insert details.
            Customer5.SetCustDetails(4, "Kate", "Jones", 19041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer5.GetCustomerID(), Customer5.GetForename(), Customer5.GetSurname(), Customer5.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle5 = new Vehicle();
            //Insert details.
            Vehicle5.SetVehicleDetails(4, "Renault", "Clio", "BT12 UJJ", 05012018, 1190, 4, "Grey", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle5.GetID(), Vehicle5.GetManufacture(), Vehicle5.GetModel(), Vehicle5.GetRegistrationNumber(), Vehicle5.GetRegistrationDate(), Vehicle5.GetEngineSize(), Vehicle5.GetOwner(), Vehicle5.GetInteriorColourCarOnly(), Vehicle5.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle5.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------


            //=============== 6 row in table =======================
            //Build new object.
            Customer Customer6 = new Customer();
            //Insert details.
            Customer6.SetCustDetails(5, "Ann", "Banks", 20041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer6.GetCustomerID(), Customer6.GetForename(), Customer6.GetSurname(), Customer6.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle6 = new Vehicle();
            //Insert details.
            Vehicle6.SetVehicleDetails(5, "Citroen", "C3", "BJ16 OIU", 06012018, 1298, 5, "Black", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle6.GetID(), Vehicle6.GetManufacture(), Vehicle6.GetModel(), Vehicle6.GetRegistrationNumber(), Vehicle6.GetRegistrationDate(), Vehicle6.GetEngineSize(), Vehicle6.GetOwner(), Vehicle6.GetInteriorColourCarOnly(), Vehicle6.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle6.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------


            //=============== 7 row in table =======================
            //Build new object.
            Customer Customer7 = new Customer();
            //Insert details.
            Customer7.SetCustDetails(6, "Jeff", "Hope", 21041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer7.GetCustomerID(), Customer7.GetForename(), Customer7.GetSurname(), Customer7.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle7 = new Vehicle();
            //Insert details.
            Vehicle7.SetVehicleDetails(6, "Renault", "Megane", "BT15 PLM", 07012018, 1380, 6, "Cream", "", "Car");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle7.GetID(), Vehicle7.GetManufacture(), Vehicle7.GetModel(), Vehicle7.GetRegistrationNumber(), Vehicle7.GetRegistrationDate(), Vehicle7.GetEngineSize(), Vehicle7.GetOwner(), Vehicle7.GetInteriorColourCarOnly(), Vehicle7.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle7.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------


            //=============== 8 row in table =======================
            //Build new object.
            Customer Customer8 = new Customer();
            //Insert details.
            Customer8.SetCustDetails(6, "Jeff", "Hope", 21041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer8.GetCustomerID(), Customer8.GetForename(), Customer8.GetSurname(), Customer8.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle8 = new Vehicle();
            //Insert details.
            Vehicle8.SetVehicleDetails(1, "Harley-Davidson", "Street 750", "AB01 ABC", 01022018, 750, 6, "", "No", "MotorCycle");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle8.GetID(), Vehicle8.GetManufacture(), Vehicle8.GetModel(), Vehicle8.GetRegistrationNumber(), Vehicle8.GetRegistrationDate(), Vehicle8.GetEngineSize(), Vehicle8.GetOwner(), Vehicle8.GetInteriorColourCarOnly(), Vehicle8.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle8.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------
            

            //=============== 9 row in table =======================
            //Build new object.
            Customer Customer9 = new Customer();
            //Insert details.
            Customer9.SetCustDetails(7, "Steven", "Beck", 22041977);
            //Write to screen.
            Console.WriteLine("Customer: {0} {1} {2} {3}", Customer9.GetCustomerID(), Customer9.GetForename(), Customer9.GetSurname(), Customer9.DateOfBirth()); //write to screen

            //-----------------------------
            //Build new object.
            Vehicle Vehicle9 = new Vehicle();
            //Insert details.
            Vehicle9.SetVehicleDetails(2, "Mike-Davidson", "Street 810", "M1KE", 02022018, 750, 7, "", "No", "MotorCycle");
            //Write to screen.
            Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle9.GetID(), Vehicle9.GetManufacture(), Vehicle9.GetModel(), Vehicle9.GetRegistrationNumber(), Vehicle9.GetRegistrationDate(), Vehicle9.GetEngineSize(), Vehicle9.GetOwner(), Vehicle9.GetInteriorColourCarOnly(), Vehicle9.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle9.GetVehicleType());
            //Space.
            Console.WriteLine();
            //-----------------------------
            Console.WriteLine("--------- end of this report ----------------------\n");
            //-------------------------- end of this report ----------------------------------------------------------------
            Console.WriteLine("Press enter for the next report.\n");

            //pause.
            Console.ReadKey(true);
            //---------------------------------------------------------------------------------------------------------

            Console.Clear(); //clear the screen.


            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("*** All vehicles with an engine size over 1100. ***\n");

            if (Vehicle1.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle1.GetID(), Vehicle1.GetManufacture(), Vehicle1.GetModel(), Vehicle1.GetRegistrationNumber(), Vehicle1.GetRegistrationDate(), Vehicle1.GetEngineSize(), Vehicle1.GetOwner(), Vehicle1.GetInteriorColourCarOnly(), Vehicle1.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle1.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle2.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle2.GetID(), Vehicle2.GetManufacture(), Vehicle2.GetModel(), Vehicle2.GetRegistrationNumber(), Vehicle2.GetRegistrationDate(), Vehicle2.GetEngineSize(), Vehicle2.GetOwner(), Vehicle2.GetInteriorColourCarOnly(), Vehicle2.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle2.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle3.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle3.GetID(), Vehicle3.GetManufacture(), Vehicle3.GetModel(), Vehicle3.GetRegistrationNumber(), Vehicle3.GetRegistrationDate(), Vehicle3.GetEngineSize(), Vehicle3.GetOwner(), Vehicle3.GetInteriorColourCarOnly(), Vehicle3.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle3.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle4.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle4.GetID(), Vehicle4.GetManufacture(), Vehicle4.GetModel(), Vehicle4.GetRegistrationNumber(), Vehicle4.GetRegistrationDate(), Vehicle4.GetEngineSize(), Vehicle4.GetOwner(), Vehicle4.GetInteriorColourCarOnly(), Vehicle4.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle4.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle5.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle5.GetID(), Vehicle5.GetManufacture(), Vehicle5.GetModel(), Vehicle5.GetRegistrationNumber(), Vehicle5.GetRegistrationDate(), Vehicle5.GetEngineSize(), Vehicle5.GetOwner(), Vehicle5.GetInteriorColourCarOnly(), Vehicle5.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle5.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle6.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle6.GetID(), Vehicle6.GetManufacture(), Vehicle6.GetModel(), Vehicle6.GetRegistrationNumber(), Vehicle6.GetRegistrationDate(), Vehicle6.GetEngineSize(), Vehicle6.GetOwner(), Vehicle6.GetInteriorColourCarOnly(), Vehicle6.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle6.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle7.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle7.GetID(), Vehicle7.GetManufacture(), Vehicle7.GetModel(), Vehicle7.GetRegistrationNumber(), Vehicle7.GetRegistrationDate(), Vehicle7.GetEngineSize(), Vehicle7.GetOwner(), Vehicle7.GetInteriorColourCarOnly(), Vehicle7.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle7.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle8.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle8.GetID(), Vehicle8.GetManufacture(), Vehicle8.GetModel(), Vehicle8.GetRegistrationNumber(), Vehicle8.GetRegistrationDate(), Vehicle8.GetEngineSize(), Vehicle8.GetOwner(), Vehicle8.GetInteriorColourCarOnly(), Vehicle8.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle8.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            if (Vehicle9.GetEngineSize() > 1100)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle9.GetID(), Vehicle9.GetManufacture(), Vehicle9.GetModel(), Vehicle9.GetRegistrationNumber(), Vehicle9.GetRegistrationDate(), Vehicle9.GetEngineSize(), Vehicle9.GetOwner(), Vehicle9.GetInteriorColourCarOnly(), Vehicle9.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle9.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            Console.WriteLine("--------- end of this report ----------------------");
            Console.WriteLine("Press enter for the next report.\n");

            //pause.
            Console.ReadKey(true);
            //---------------------------------------------------------------------------------------------------------

            Console.Clear(); //clear the screen.

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("*** All vehicles registered before 01 01 2010. ***\n");

            if (Vehicle1.GetRegistrationDate() < 01012010)
            {
                Console.WriteLine("Vehicle: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", Vehicle1.GetID(), Vehicle1.GetManufacture(), Vehicle1.GetModel(), Vehicle1.GetRegistrationNumber(), Vehicle1.GetRegistrationDate(), Vehicle1.GetEngineSize(), Vehicle1.GetOwner(), Vehicle1.GetInteriorColourCarOnly(), Vehicle1.GetHasHelmetStoreageMotorCyclesOnly(), Vehicle1.GetVehicleType());
                //Space.
                Console.WriteLine();
            }
            
            //------------------- I know that this was the only vehicle to test. ---------------------------------

            Console.WriteLine("--------- end of this report ----------------------");
            Console.WriteLine("Press enter for the next report.\n");

            //pause.
            Console.ReadKey(true);
            //---------------------------------------------------------------------------------------------------------

            Console.Clear(); //clear the screen.






            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("*** All customers between the age 20-30. ***\n");

            // only one that needs testing.

            //--- working out the age by getting the year from their DOB.---
            //convert dob int to string.
            string foo1 = Customer1.DateOfBirth().ToString();
            //count after 4 from the left to get the year.
            string bar1 = foo1.Substring(4);
            //convert to int.
            int answer1 = Convert.ToInt32(bar1);
            
            int YearNow1 = DateTime.Now.Year;
            int age1;
            age1 = YearNow1 - answer1;

            //check the age is within range.
            if ( age1 >19 && age1 <31)
            {
                //Write to screen if is ok.
                Console.WriteLine("Customer: {0} {1} {2} {3}", Customer1.GetCustomerID(), Customer1.GetForename(), Customer1.GetSurname(), Customer1.DateOfBirth()); //write to screen

            }

            
            Console.WriteLine("--------- end of this report ----------------------");
            Console.WriteLine("Press enter.");

            //pause.
            Console.ReadKey(true);
            //---------------------------------------------------------------------------------------------------------


        }
    }
}