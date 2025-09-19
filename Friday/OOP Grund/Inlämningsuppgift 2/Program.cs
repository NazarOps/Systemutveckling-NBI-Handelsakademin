namespace Inlämningsuppgift_2
{
    public class Gym
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GymExperience = "Novice";
            
            customer.Experience();

            Person person = new Person("John Doe", 25, "Male");
            person.InfoAboutPerson();

            Membership membership = new Membership("Active");
            membership.MembershipStatus = "Active";
            membership.StartDate = 20250801;
            membership.EndDate = 20260801;
            
            membership.ShowMembershipStatus();
            membership.RenewMembership();
            membership.CancelMembership();

            Employee employee = new Employee();
            employee.NumberofStaff = 5;
            employee.WorkExperience = 10;

            employee.info();

            BenchPress benchPress = new BenchPress();
            benchPress.Brand = "Eleiko";
            benchPress.AmountOfEquipment = 4;
            benchPress.Condition = "Brand new";

            benchPress.InUse();

            SquatRack squatRack = new SquatRack();
            squatRack.Brand = "Eleiko";
            squatRack.AmountOfEquipment = 3;
            squatRack.Condition = "Worn out";

            squatRack.InUse();

            Machines machines = new Machines();
            machines.Brand = "Hammer Strength";
            machines.AmountOfEquipment = 10;
            machines.Condition = "decent";

            machines.InUse();

            Equipment equipment = new Equipment();
            equipment.Brand = "Life Fitness";
            equipment.Condition = "a bit worn out";
            equipment.Type = "Chest Press";
            equipment.AmountOfEquipment = 10;

            equipment.info();
        }
    }
}