namespace Tinder
{
    public class TinderUser
    {
        #region Atributos
        private string _name;
        private int _age;
        private string _picture;
        private string _description;
        private int _valoration;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public bool HasOneStar => Rating > 10;
        #endregion


    }
}
