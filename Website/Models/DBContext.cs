using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base()
        {
        }
        //public DbSet<User_Date_Base> User_Date_Bases { get; set; }
        //public DbSet<DateBaseEntity> Date_Bases { get; set; }
        public DbSet<SectionIntro> SectionIntro { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Dictionary> Dictionary { get; set; }
        public DbSet<SectionLatestNew> SectionLatestNew { get; set; }
        public DbSet<SectionLatestNewList> SectionLatestNewList { get; set; }
        public DbSet<Miscellaneous> Miscellaneous { get; set; }
        public DbSet<SectionEvent> SectionEvent { get; set; }
        public DbSet<SectionEventList> SectionEventList { get; set; }
        public DbSet<SectionCurrentlyShowingList> SectionCurrentlyShowingList { get; set; }
        public DbSet<SectionCurrentlyShowing> SectionCurrentlyShowing { get; set; }
        public DbSet<SectionService> SectionService { get; set; }
        public DbSet<SectionLatestServiceList> SectionLatestServiceList { get; set; }
        public DbSet<SectionLatestService> SectionLatestService { get; set; }
        public DbSet<SectionAssociation> SectionAssociation { get; set; }
        public DbSet<SectionAssociationMember> SectionAssociationMember { get; set; }
        public DbSet<SectionDivision> SectionDivision { get; set; }
        public DbSet<SectionAssociationCouncilWord> SectionAssociationCouncilWord { get; set; }
        public DbSet<SectionContact> SectionContact { get; set; }
        public DbSet<SectionContactFooter> SectionContactFooter { get; set; }
        public DbSet<SectionCinemaLibraryFooter> SectionCinemaLibraryFooter { get; set; }
        public DbSet<SectionFooter> SectionFooter { get; set; }
        public DbSet<SectionAssociationFooter> SectionAssociationFooter { get; set; }
        public DbSet<SectionVisiblity> SectionVisiblity { get; set; }
        public DbSet<User> User { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CinemaLibraryFooter Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.CinemaLibraryFooter_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_CinemaLibraryFooter")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CinemaLibraryFooter_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_CinemaLibraryFooter")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CinemaLibraryFooter_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_CinemaLibraryFooter")
                .OnDelete(DeleteBehavior.NoAction);

            //Contact Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Contact_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Contact")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contact_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Contact")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contact_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Contact")
                .OnDelete(DeleteBehavior.NoAction);

            //ContactFooter Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactFooter_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_ContactFooter")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactFooter_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_ContactFooter")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ContactFooter_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_ContactFooter")
                .OnDelete(DeleteBehavior.NoAction);

            //CurrentlyShowing Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.CurrentlyShowing_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_CurrentlyShowing")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CurrentlyShowing_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_CurrentlyShowing")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CurrentlyShowing_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_CurrentlyShowing")
                .OnDelete(DeleteBehavior.NoAction);

            //CurrentlyShowingList Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.CurrentlyShowingList_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_CurrentlyShowingList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CurrentlyShowingList_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_CurrentlyShowingList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CurrentlyShowingList_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_CurrentlyShowingList")
                .OnDelete(DeleteBehavior.NoAction);

            //Dictionary Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Dictionary_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Dictionary")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Dictionary_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Dictionary")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Dictionary_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Dictionary")
                .OnDelete(DeleteBehavior.NoAction);

            //Division Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Division_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Division")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Division_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Division")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Division_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Division")
                .OnDelete(DeleteBehavior.NoAction);

            //Event Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Event_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Event")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Event_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Event")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Event_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Event")
                .OnDelete(DeleteBehavior.NoAction);

            //EventList Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.EventList_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_EventList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.EventList_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_EventList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.EventList_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_EventList")
                .OnDelete(DeleteBehavior.NoAction);

            //Footer Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Footer_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Footer")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Footer_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Footer")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Footer_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Footer")
                .OnDelete(DeleteBehavior.NoAction);

            //Guild Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Guild_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Guild")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Guild_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Guild")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Guild_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Guild")
                .OnDelete(DeleteBehavior.NoAction);

            //GuildFooter Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.GuildFooter_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_GuildFooter")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GuildFooter_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_GuildFooter")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GuildFooter_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_GuildFooter")
                .OnDelete(DeleteBehavior.NoAction);

            //GuildMember Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.GuildMember_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_GuildMember")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GuildMember_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_GuildMember")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GuildMember_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_GuildMember")
                .OnDelete(DeleteBehavior.NoAction);

            //Intro Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Intro_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Intro")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Intro_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Intro")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Intro_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Intro")
                .OnDelete(DeleteBehavior.NoAction);

            //Language Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Language_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Language")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Language_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Language")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Language_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Language")
                .OnDelete(DeleteBehavior.NoAction);

            //LatestNew Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestNew_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_LatestNew")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestNew_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_LatestNew")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestNew_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_LatestNew")
                .OnDelete(DeleteBehavior.NoAction);

            //LatestNewsList Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestNewsList_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_LatestNewsList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestNewsList_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_LatestNewsList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestNewsList_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_LatestNewsList")
                .OnDelete(DeleteBehavior.NoAction);

            //LatestService Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestService_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_LatestService")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestService_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_LatestService")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestService_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_LatestService")
                .OnDelete(DeleteBehavior.NoAction);

            //LatestServiceList Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestServiceList_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_LatestServiceList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestServiceList_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_LatestServiceList")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.LatestServiceList_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_LatestServiceList")
                .OnDelete(DeleteBehavior.NoAction);

            //Miscellaneous Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Miscellaneous_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Miscellaneous")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Miscellaneous_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Miscellaneous")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Miscellaneous_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Miscellaneous")
                .OnDelete(DeleteBehavior.NoAction);

            //Service Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.Service_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_Service")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Service_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_Service")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Service_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_Service")
                .OnDelete(DeleteBehavior.NoAction);

            //SyndicateCouncilWord Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.SyndicateCouncilWord_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_SyndicateCouncilWord")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SyndicateCouncilWord_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_SyndicateCouncilWord")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SyndicateCouncilWord_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_SyndicateCouncilWord")
                .OnDelete(DeleteBehavior.NoAction);

            //SectionVisiblity Table
            modelBuilder.Entity<User>()
                .HasMany(e => e.SectionVisiblity_CreationUsers)
                .WithOne(e => e.CreationUser)
                .HasForeignKey(e => e.CreationUserID)
                .HasConstraintName("FK_UserCreation_SectionVisiblity")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SectionVisiblity_ModifyUsers)
                .WithOne(e => e.ModifyUser)
                .HasForeignKey(e => e.ModifyUserID)
                .HasConstraintName("FK_UserModify_SectionVisiblity")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SectionVisiblity_DeleteUsers)
                .WithOne(e => e.DeleteUser)
                .HasForeignKey(e => e.DeleteUserID)
                .HasConstraintName("FK_UserDelete_SectionVisiblity")
                .OnDelete(DeleteBehavior.NoAction);




        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ClassLibrary;Persist Security Info=True;User ID=sa;Password=abc_123");
        }
    }
}
