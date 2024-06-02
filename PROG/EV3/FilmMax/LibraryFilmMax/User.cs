using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryFilmMax
{    	
	//[BsonIgnoreExtraElements]
	
    public class User
    {
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
        public ObjectId id { get; set; }

        //[BsonElement("security")]
        //TODO: El parámetro que recibe la etiqueta, corresponde con el nombre del atributo del documento BSON
        //Esto es útil cuando los nombres de los atributos del documento son DIFERENTES o son PASCAL CASE
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
        public int dayDate { get; set; }
        public int monthDate { get; set; }
        public int yearDate { get; set; }
    }    
}