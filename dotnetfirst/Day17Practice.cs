// using System;

// class BaseClass
// {
//     public static void StaticMethod()
//     {
//         Console.WriteLine("BaseClass.StaticMethod()");
//     }
// }

// class DerivedClass : BaseClass
// {
//     public new static void StaticMethod()
//     {
//         Console.WriteLine("DerivedClass.StaticMethod()");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {

//         BaseClass.StaticMethod(); 
//         DerivedClass.StaticMethod(); 
//     }
// }



// using System;

// abstract class BaseClass
// {
//     public static void StaticMethod()
//     {
//         Console.WriteLine("From base class");
//     }
// }

// class DerivedClass : BaseClass
// {
//     public override void StaticMethod()
//     {
//         Console.WriteLine("from derived class");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         BaseClass.StaticMethod();
//         DerivedClass.StaticMethod();
//     }
// }



// using System;

// class MedialFiles
// {
//     public string? fileName { get; set; }
//     public DateTime Date { get; set; }
//     public long FileSize { get; set; }
// }


// class AudioFile : MedialFiles
// {
//     public string? Artist { get; set; }
//     public int Duration { get; set; }

//     public void DisplayAudioDetails()
//     {
//         Console.WriteLine("Name of the audio file : " + fileName);
//         Console.WriteLine("Date of the audio file : " + Date);
//         Console.WriteLine("Size of the audio file : " + FileSize);

//         Console.WriteLine("Name of the artist :" + Artist);
//         Console.WriteLine("Duration of the audio file :" + Duration);
//     }
// }


// class VideoFile : MedialFiles
// {
//     public string? actor { get; set; }
//     public int Duration { get; set; }

//     public void DisplayVideoDetails()
//     {



//         System.Console.WriteLine("Duration of video is : " + Duration);
//         System.Console.WriteLine("Leading role in this video is : " + actor);

//         System.Console.WriteLine("Name of the Video file : " + fileName);
//         System.Console.WriteLine("Date of the video file : " + Date);
//         System.Console.WriteLine("Size of the video file : " + FileSize);

//     }
// }

// class Podcast : MedialFiles
// {
//     public string? Host { get; set; }
//     public int EpisodeNumber { get; set; }

//     public void DisplayPodcastDetails()
//     {
//         Console.WriteLine("Podcast Details:");

//         System.Console.WriteLine("File Name  :" + fileName);
//         System.Console.WriteLine("Date Added : " + Date);
//         System.Console.WriteLine("File Size : " + FileSize);
//         System.Console.WriteLine("Host of the podcast : " + Host);
//         System.Console.WriteLine("Episode number : " + EpisodeNumber);
//     }
// }
// class MultimediaClass
// {

//     public static void Main(string[] args)
//     {
//         AudioFile audioFile = new AudioFile();


//         Console.WriteLine("Enter the details of the Audio file:");
//         Console.Write("File Name: ");
//         audioFile.fileName = Console.ReadLine();
//         Console.Write("Artist: ");
//         audioFile.Artist = Console.ReadLine();
//         Console.Write("Duration (Minuntes): ");
//         audioFile.Duration = Convert.ToInt32(Console.ReadLine());

//         audioFile.Date = DateTime.Now;
//         audioFile.DisplayAudioDetails();



//         VideoFile videoFile = new VideoFile();
//         Console.WriteLine("Enter the details of the video file:");
//         Console.Write("File Name: ");
//         videoFile.fileName = Console.ReadLine();
//         Console.Write("Actor: ");
//         videoFile.actor = Console.ReadLine();
//         Console.Write("Duration (Minuntes): ");
//         videoFile.Duration = Convert.ToInt32(Console.ReadLine());

//         videoFile.Date = DateTime.Now;
//         videoFile.DisplayVideoDetails();



//         Podcast podcast = new Podcast();
//         Console.WriteLine("Enter the details of the podcast file:");
//         Console.Write("File Name: ");
//         podcast.fileName = Console.ReadLine();
//         Console.Write("Host: ");
//         podcast.Host = Console.ReadLine();
//         Console.Write("Duration (Minuntes): ");
//         videoFile.Duration = Convert.ToInt32(Console.ReadLine());

//     }

// }