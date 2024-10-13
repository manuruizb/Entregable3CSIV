namespace Entregable3.Dtos
{
    public class CharacterDto {
        public int id {get; set; }
        public string? name {get; set; }
        public string? status {get; set; }
        public string? species {get; set; }
        public string? type {get; set; }
        public string? gender {get; set; }
        public string? image {get; set; }
        public LocationDto? location {get; set; }
    }
}