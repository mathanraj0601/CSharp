namespace RecursiveWebApi.Models.ViewModel
{
    public class StandardViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<StandardViewModel>? Child { get; set; }

        public override string ToString()
        {
            string result = " ID " + Id;
            result += " Name " + Name;
            //if( Child == null ) return result+ " No Child ";
            //result += " Child are ";
            // foreach (var item in this.Child)
            //{
            //    result += item.ToString()+" ";
            //}
            return result;

        }
    }
}
