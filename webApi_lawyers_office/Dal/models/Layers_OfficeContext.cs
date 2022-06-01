using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dal.models
{
    public partial class Layers_OfficeContext : DbContext
    {
        public Layers_OfficeContext()
        {
        }

        public Layers_OfficeContext(DbContextOptions<Layers_OfficeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<ActionPattern> ActionPatterns { get; set; }
        public virtual DbSet<ActionsToBag> ActionsToBags { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Bag> Bags { get; set; }
        public virtual DbSet<BagsToPerson> BagsToPeople { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FilePattern> FilePatterns { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-A8BTK9B\\SQL2019;Database=Layers_Office;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFileId).HasColumnName("action_file_id");

                entity.Property(e => e.ActionPatternId).HasColumnName("action_pattern_id");

                entity.Property(e => e.ActionPriority).HasColumnName("action_priority");

                entity.Property(e => e.ActionState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_state")
                    .HasDefaultValueSql("('waiting')");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeadLine)
                    .HasColumnType("date")
                    .HasColumnName("dead_line");

                entity.HasOne(d => d.ActionFile)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.ActionFileId)
                    .HasConstraintName("FK_Actions_files");

                entity.HasOne(d => d.ActionPattern)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.ActionPatternId)
                    .HasConstraintName("FK_Actions_Action_patterns");
            });

            modelBuilder.Entity<ActionPattern>(entity =>
            {
                entity.ToTable("Action_patterns");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionLevel).HasColumnName("action_level");

                entity.Property(e => e.ActionPatternName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("action_pattern_name");

                entity.Property(e => e.Discription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("discription");

                entity.Property(e => e.FilePatternId).HasColumnName("file_pattern_id");

                entity.Property(e => e.LinkId).HasColumnName("link_id");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.WaitingForPatternId).HasColumnName("waiting_for_pattern_id");

                entity.Property(e => e.WhomFor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("whom_for")
                    .HasDefaultValueSql("('lawyer')");

                entity.HasOne(d => d.FilePattern)
                    .WithMany(p => p.ActionPatterns)
                    .HasForeignKey(d => d.FilePatternId)
                    .HasConstraintName("FK_Action_patterns_File_patterns");

                entity.HasOne(d => d.Link)
                    .WithMany(p => p.ActionPatterns)
                    .HasForeignKey(d => d.LinkId)
                    .HasConstraintName("FK_Action_patterns_Links");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ActionPatterns)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Action_patterns_Payments");

                entity.HasOne(d => d.WaitingForPattern)
                    .WithMany(p => p.InverseWaitingForPattern)
                    .HasForeignKey(d => d.WaitingForPatternId)
                    .HasConstraintName("FK_Action_patterns_Action_patterns");
            });

            modelBuilder.Entity<ActionsToBag>(entity =>
            {
                entity.ToTable("Actions_to_Bags");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.BagId).HasColumnName("bag_id");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionsToBags)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_Actions_to_Bags_Actions");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.ActionsToBags)
                    .HasForeignKey(d => d.BagId)
                    .HasConstraintName("FK_Actions_to_Bags_Bags");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("asset_address");

                entity.Property(e => e.BlockOrBook)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("block_or_book");

                entity.Property(e => e.OtherDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("other_details");

                entity.Property(e => e.PlotOrPage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plot_or_page");

                entity.Property(e => e.SubPlot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_plot");

                entity.Property(e => e.TikMinhal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tik_minhal");
            });

            modelBuilder.Entity<Bag>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.BagName).HasColumnName("bag_name");

                entity.Property(e => e.BagState).HasColumnName("bag_state");

                entity.Property(e => e.DateClose)
                    .HasColumnType("date")
                    .HasColumnName("date_close");

                entity.Property(e => e.LastOpen)
                    .HasColumnType("datetime")
                    .HasColumnName("last_open");

                entity.Property(e => e.ModificationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modification_time")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Bags)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bags_Assets");
            });

            modelBuilder.Entity<BagsToPerson>(entity =>
            {
                entity.ToTable("Bags_to_People");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BagId).HasColumnName("bag_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.PersonType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("person_type")
                    .HasDefaultValueSql("('lawyer')");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.BagsToPeople)
                    .HasForeignKey(d => d.BagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bags_to_People_Bags");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.BagsToPeople)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bags_to_People_People");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BagId).HasColumnName("bag_id");

                entity.Property(e => e.FileDir)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("file_dir");

                entity.Property(e => e.FilePatternId).HasColumnName("file_pattern_id");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.BagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Files_Bags");

                entity.HasOne(d => d.FilePattern)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.FilePatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Files_File_patterns");
            });

            modelBuilder.Entity<FilePattern>(entity =>
            {
                entity.ToTable("File_patterns");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Access).HasColumnName("access");

                entity.Property(e => e.Discription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("discription");

                entity.Property(e => e.FilePatternName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("File_pattern_name");
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("link_name");

                entity.Property(e => e.SiteAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("site_address");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("discription");

                entity.Property(e => e.FinalSum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("final_sum");

                entity.Property(e => e.PaySum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pay_sum");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("payment_name");

                entity.Property(e => e.SumOff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sum_off");

                entity.Property(e => e.WhoToPay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("who_to_pay");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.LivingAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("living_address");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.SecondPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("second_phone");

                entity.Property(e => e.Tz)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("tz");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_password");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_type")
                    .HasDefaultValueSql("('customer')");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_People");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
