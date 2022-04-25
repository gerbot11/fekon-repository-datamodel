using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace fekon_repository_datamodel.Models
{
    public partial class REPOSITORY_DEVContext : DbContext
    {
        public REPOSITORY_DEVContext()
        {
        }

        public REPOSITORY_DEVContext(DbContextOptions<REPOSITORY_DEVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<CollectionD> CollectionDs { get; set; }
        public virtual DbSet<CollectionDlist> CollectionDlists { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<DownloadStatistic> DownloadStatistics { get; set; }
        public virtual DbSet<FileDetail> FileDetails { get; set; }
        public virtual DbSet<FileMonitoringHist> FileMonitoringHists { get; set; }
        public virtual DbSet<FileMonitoringResult> FileMonitoringResults { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<RefCollection> RefCollections { get; set; }
        public virtual DbSet<RefEmployee> RefEmployees { get; set; }
        public virtual DbSet<RefKeyword> RefKeywords { get; set; }
        public virtual DbSet<RefLanguage> RefLanguages { get; set; }
        public virtual DbSet<RefRepositoryFileType> RefRepositoryFileTypes { get; set; }
        public virtual DbSet<RepoStatistic> RepoStatistics { get; set; }
        public virtual DbSet<Repository> Repositories { get; set; }
        public virtual DbSet<RepositoryD> RepositoryDs { get; set; }
        public virtual DbSet<RepositoryKeyword> RepositoryKeywords { get; set; }
        public virtual DbSet<UserActivityHist> UserActivityHists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.AuthorNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdvisor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CollectionD>(entity =>
            {
                entity.ToTable("CollectionD");

                entity.Property(e => e.CollectionDid).HasColumnName("CollectionDId");

                entity.Property(e => e.CollectionDname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CollectionDName");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CollectionDs)
                    .HasForeignKey(d => d.CommunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Collectio__Commu__02084FDA");

                entity.HasOne(d => d.RefCollection)
                    .WithMany(p => p.CollectionDs)
                    .HasForeignKey(d => d.RefCollectionId)
                    .HasConstraintName("FK__Collectio__RefCo__71D1E811");
            });

            modelBuilder.Entity<CollectionDlist>(entity =>
            {
                entity.ToTable("CollectionDList");

                entity.Property(e => e.CollectionDlistId).HasColumnName("CollectionDListId");

                entity.Property(e => e.CollectionDid).HasColumnName("CollectionDId");

                entity.Property(e => e.CollectionDlistName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CollectionDListName");

                entity.HasOne(d => d.CollectionD)
                    .WithMany(p => p.CollectionDlists)
                    .HasForeignKey(d => d.CollectionDid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Collectio__Colle__3F466844");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("Community");

                entity.Property(e => e.CommunityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CommunityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadStatistic>(entity =>
            {
                entity.ToTable("DownloadStatistic");

                entity.Property(e => e.DownloadDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorMsg)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.FileDetail)
                    .WithMany(p => p.DownloadStatistics)
                    .HasForeignKey(d => d.FileDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DownloadS__FileD__29221CFB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DownloadStatistics)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DownloadS__UserI__2A164134");
            });

            modelBuilder.Entity<FileDetail>(entity =>
            {
                entity.ToTable("FileDetail");

                entity.Property(e => e.FileExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OriginFileName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.RefRepositoryFileType)
                    .WithMany(p => p.FileDetails)
                    .HasForeignKey(d => d.RefRepositoryFileTypeId)
                    .HasConstraintName("FK__FileDetai__RefRe__69FBBC1F");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.FileDetails)
                    .HasForeignKey(d => d.RepositoryId)
                    .HasConstraintName("FK__FileDetai__Repos__2C3393D0");
            });

            modelBuilder.Entity<FileMonitoringHist>(entity =>
            {
                entity.ToTable("FileMonitoringHist");

                entity.Property(e => e.RunningDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileMonitoringResult>(entity =>
            {
                entity.ToTable("FileMonitoringResult");

                entity.Property(e => e.StatusFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.FileDetail)
                    .WithMany(p => p.FileMonitoringResults)
                    .HasForeignKey(d => d.FileDetailId)
                    .HasConstraintName("FK__FileMonit__FileD__2FCF1A8A");

                entity.HasOne(d => d.FileMonitoringHist)
                    .WithMany(p => p.FileMonitoringResults)
                    .HasForeignKey(d => d.FileMonitoringHistId)
                    .HasConstraintName("FK__FileMonit__FileM__2EDAF651");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");

                entity.Property(e => e.PublisherName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefCollection>(entity =>
            {
                entity.ToTable("RefCollection");

                entity.Property(e => e.CollCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CollName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefEmployee>(entity =>
            {
                entity.ToTable("RefEmployee");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePicLoc)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefEmployees)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__RefEmploy__UserI__4F47C5E3");
            });

            modelBuilder.Entity<RefKeyword>(entity =>
            {
                entity.ToTable("RefKeyword");

                entity.Property(e => e.KeywordCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeywordName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefLanguage>(entity =>
            {
                entity.HasKey(e => e.LangCode)
                    .HasName("PK__RefLangu__F43B705372DC863F");

                entity.ToTable("RefLanguage");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LangName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefRepositoryFileType>(entity =>
            {
                entity.ToTable("RefRepositoryFileType");

                entity.Property(e => e.RepositoryFileTypeCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RepositoryFileTypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepoStatistic>(entity =>
            {
                entity.ToTable("RepoStatistic");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.RepoStatistics)
                    .HasForeignKey(d => d.RepositoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RepoStati__Repos__4BAC3F29");
            });

            modelBuilder.Entity<Repository>(entity =>
            {
                entity.ToTable("Repository");

                entity.Property(e => e.CollectionDid).HasColumnName("CollectionDId");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.Property(e => e.UsrCreate).HasMaxLength(450);

                entity.HasOne(d => d.CollectionD)
                    .WithMany(p => p.Repositories)
                    .HasForeignKey(d => d.CollectionDid)
                    .HasConstraintName("FK__Repositor__Colle__70DDC3D8");

                entity.HasOne(d => d.Communitiy)
                    .WithMany(p => p.Repositories)
                    .HasForeignKey(d => d.CommunitiyId)
                    .HasConstraintName("FK__Repositor__Commu__01142BA1");

                entity.HasOne(d => d.PublisherNavigation)
                    .WithMany(p => p.Repositories)
                    .HasForeignKey(d => d.Publisher)
                    .HasConstraintName("FK__Repositor__Publi__29572725");

                entity.HasOne(d => d.RefCollection)
                    .WithMany(p => p.Repositories)
                    .HasForeignKey(d => d.RefCollectionId)
                    .HasConstraintName("FK__Repositor__RefCo__5AEE82B9");
            });

            modelBuilder.Entity<RepositoryD>(entity =>
            {
                entity.ToTable("RepositoryD");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.RepositoryDs)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Repositor__Autho__48CFD27E");

                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.RepositoryDs)
                    .HasForeignKey(d => d.RepositoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Repositor__Repos__47DBAE45");
            });

            modelBuilder.Entity<RepositoryKeyword>(entity =>
            {
                entity.ToTable("RepositoryKeyword");

                entity.HasOne(d => d.RefKeyword)
                    .WithMany(p => p.RepositoryKeywords)
                    .HasForeignKey(d => d.RefKeywordId)
                    .HasConstraintName("FK__Repositor__RefKe__6AEFE058");

                entity.HasOne(d => d.Repostiory)
                    .WithMany(p => p.RepositoryKeywords)
                    .HasForeignKey(d => d.RepostioryId)
                    .HasConstraintName("FK__Repositor__Repos__671F4F74");
            });

            modelBuilder.Entity<UserActivityHist>(entity =>
            {
                entity.ToTable("UserActivityHist");

                entity.Property(e => e.ActivityAction)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityDesc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTime).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserActivityHists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserActiv__UserI__5224328E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
