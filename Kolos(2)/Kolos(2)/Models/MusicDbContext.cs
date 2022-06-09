using Kolos_2_.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace Kolos_2_.Models
{
    public interface IMusicDbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<MusicianTrack> MusicianTracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Track> Tracks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
    public class MusicDbContext : DbContext, IMusicDbContext
    {
        private IConfiguration _configuration;
        public MusicDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public MusicDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Musician> Musicians { get; set; }
        public virtual DbSet<MusicianTrack> MusicianTracks { get; set; }
        public virtual DbSet<MusicLabel> MusicLabels { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Track>(m =>
            {
                m.HasKey(m =>m.IdTrack);
                m.Property(m => m.TrackName);
                m.Property(m => m.Duration);
                m.HasOne(m => m.Album).WithMany(m => m.Track).HasForeignKey(m => m.IdMusicAlbum);
                m.HasData(
                    new Track { IdTrack = 1, TrackName = "Cos", Duration = 200 });

            });
            modelBuilder.Entity<Musician>(m =>
            {
                m.HasKey(m => m.IdMusician);
                m.Property(m => m.FirstName);
                m.Property(m => m.LastName);
                m.Property(m => m.Nickname);
                
                m.HasData(
                    new Musician { IdMusician = 1, FirstName = "Kamil", LastName = "Bakowski" , Nickname ="Facio"});

            });
            modelBuilder.Entity<Album>(m =>
            {
                m.HasKey(m => m.IdAlbum);
                m.Property(m => m.IdMusicLabel);
                m.Property(m => m.AlbumName);
                m.Property(m => m.PublishDate);
                m.HasOne(m => m.MusicLabel).WithMany(m => m.Album).HasForeignKey(m => m.IdMusicAlbum);
                m.HasData(
                    new Album { IdAlbum = 1, IdMusicLabel = 1, AlbumName = "BakaJOko", PublishDate =new System.DateTime(21,1,2005) });

            });
            modelBuilder.Entity<MusicianTrack>(m =>
            {
                m.HasKey(m => m.IdTrack);
                m.Property(m => m.IdMusician);
                m.HasOne(m => m.Musician).WithMany(m => m.MusicianTrack).HasForeignKey(m => m.IdMusician);
                m.HasOne(m => m.Track).WithMany(m => m.MusicianTrack).HasForeignKey(m => m.IdTrack);
                m.HasData(
                    new Album { IdAlbum = 1, IdMusicLabel = 1, AlbumName = "BakaJOko", PublishDate = new System.DateTime(21, 1, 2005) });

            });
            modelBuilder.Entity<MusicLabel>(m =>
            {
                m.HasKey(m => m.IdAlbum);
                m.Property(m => m.IdMusicLabel);
                m.Property(m => m.AlbumName);
                m.Property(m => m.PublishDate);
                m.HasOne(m => m.MusicLabel).WithMany(m => m.Album).HasForeignKey(m => m.IdMusicAlbum);
                m.HasData(
                    new Album { IdAlbum = 1, IdMusicLabel = 1, AlbumName = "BakaJOko", PublishDate = new System.DateTime(21, 1, 2005) });

            });

        }
    }
}
