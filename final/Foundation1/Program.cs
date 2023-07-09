using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Relaxing Western Guitar Music | American Wild West Ambient Music | 4K", "Visual Melodies","https://www.youtube.com/watch?v=HsAAvjLeV-E",  7247);
        video1.AddComment("@HistoryTeacher1984", "Relaxing Western Guitar Music | American Wild West Ambient Music | 4K");
        video1.AddComment("@Chaser-it3gn", "This is GOLD. Can't say how much peace I find instantly. Now being played on and off at our work/home but will be most of the time as a background music after the holidays.");
        video1.AddComment("@dianashepherd3241", "this sort of western music along with celtic music is probably the most calming and wholesome music i know of.");
        videos.Add(video1);

        Video video2 = new Video("NARRADOR INGLÊS ENLOUQUECE COM A VIRADA DO FLAMENGO", "Pedro Almeida Almeida", "https://www.youtube.com/watch?v=BAQCT1Wux5Y" ,176);
        video2.AddComment("@yangsouza7369", "Não consigo assistir um vídeo do Flamengo ganhando a liberta sem me emocionar, simplesmente foi o melhor dia da minha vida.");
        video2.AddComment("@jorgeaugustodeoliveiradoss3058", "It was one of the best days of my whole life.");
        video2.AddComment("@walissonsousa8953", "Gabigol pode não ter tido sucesso na Europa ainda, mas já fez sua história na Americana do Sul nunca vi um jogador decidir uma final tão dramática, esse cara ainda vai fazer sucesso lá fora pode anotar isso");
        videos.Add(video2);

        Video video3 = new Video("Os ensinamentos de Jesus Cristo | Dallin H. Oaks | Abril 2023 Conferencia General", "Conferência Geral", "https://www.youtube.com/watch?v=8a9r1eGOWwA" , 888);
        video3.AddComment("@juanfurtadolacerda4594", "Cristo Vive  é nosso Salvador ,,,");
        video3.AddComment("@elaneuchoa9575", "As Conferências São Maravilhosas Quem Participa Tem Humildes no Coração e Está em Espírito Santo AMÉM");
        video3.AddComment("@sueliandradelucas1455", "Sou grata por fazer parte da igreja de Jesus Cristo ❤");
        videos.Add(video3);

        Console.WriteLine("");
        Console.WriteLine("Videos: ");
        Console.WriteLine("");
        foreach (Video video in videos)
        {
            video.DisplayVideosDetails();
            Console.WriteLine();
        }
    }
}