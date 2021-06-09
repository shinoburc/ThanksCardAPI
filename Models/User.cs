namespace ThanksCardAPI.Models
{
    public class User
    {
        

        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        // ����1: User �G���e�B�e�B��1�� Department �G���e�B�e�B�ɑ�����
        public long? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        
    }
}
