using oops_and_basics;
namespace oops_and_basics {
    public class Department : Employee {
        private string _departmentName;
        public Department () {

        }
        public Department (string departmentName) {
            this._departmentName = departmentName;
        }
        public string DepartmentName {
            get { return _departmentName; }
            set { _departmentName = value; }
        }
        public string GetDepartmentName (string name) {
            return name;
        }
    }
}