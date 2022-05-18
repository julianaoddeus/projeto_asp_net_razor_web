using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {

        //campo ID é necessário para o banco de dados como chave primária
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        //DATATYPE especifica o tipo de dados
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

}
   