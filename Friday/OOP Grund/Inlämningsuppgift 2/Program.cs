namespace Inlämningsuppgift_2
{
    public class Gym
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GymExperience = "Novice";
            
            customer.Experience();

            Person person = new Person("John Doe");
            person.Name = "John Doe";
            person.Age = 25;
            person.Gender = "Male";

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

            Bench_press bench_Press = new Bench_press();
            bench_Press.Brand = "Eleiko";
            bench_Press.AmountofEquipment = 4;
            bench_Press.Condition = "Brand new";

            bench_Press.InUse();

            Squat_racks squat_rack = new Squat_racks();
            squat_rack.Brand = "Eleiko";
            squat_rack.AmountofEquipment = 3;
            squat_rack.Condition = "Worn out";

            squat_rack.InUse();

            Machines machines = new Machines();
            machines.Brand = "Hammer Strength";
            machines.AmountofEquipment = 10;
            machines.Condition = "decent";

            machines.InUse();

            Equipment equipment = new Equipment();
            equipment.Brand = "Life Fitness";
            equipment.Condition = "A bit worn out";
            equipment.Type = "Chest Press";
            equipment.AmountofEquipment = 10;

            equipment.info();
        }
    }
}