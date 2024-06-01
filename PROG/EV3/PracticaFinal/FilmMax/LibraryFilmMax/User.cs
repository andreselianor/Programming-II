using MongoDB.Bson;

namespace LibraryFilmMax
{    

	
	//[BsonIgnoreExtraElements]
	
    public class User
    {
		// [BsonId]
		// [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId id { get; set; }
        public Security security { get; set; }
        public string userName { get; set; }
        public string lastName { get; set; }
        public BirthDate birthDate { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string favouriteFilms { get; set; }
    }
    public class Security
    {
        public string loginName { get; set; }
        public string loginPassword { get; set; }
    }
    public class BirthDate
    {
		// [BsonElement("nombredelabasededatos")]
		// La anotacion vincula el atributo C# con el atributo de la DB
        public int dayDate { get; set; }
        public int monthDate { get; set; }
        public int yearDate { get; set; }
    }    
}