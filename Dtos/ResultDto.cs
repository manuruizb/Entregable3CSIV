namespace Entregable3.Dtos
{
    public class ResultDto<T> {
        public InfoDto? info {get; set; }
        public T? results {get; set; }
    }
}