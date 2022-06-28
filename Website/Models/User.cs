using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(100)]
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        //CinemaLibraryFooter
        public virtual ICollection<SectionCinemaLibraryFooter> CinemaLibraryFooter_CreationUsers { get; set; }
        public virtual ICollection<SectionCinemaLibraryFooter> CinemaLibraryFooter_ModifyUsers { get; set; }
        public virtual ICollection<SectionCinemaLibraryFooter> CinemaLibraryFooter_DeleteUsers { get; set; }
        //Contact
        public virtual ICollection<SectionContact> Contact_CreationUsers { get; set; }
        public virtual ICollection<SectionContact> Contact_ModifyUsers { get; set; }
        public virtual ICollection<SectionContact> Contact_DeleteUsers { get; set; }
        //ContactFooter
        public virtual ICollection<SectionContactFooter> ContactFooter_CreationUsers { get; set; }
        public virtual ICollection<SectionContactFooter> ContactFooter_ModifyUsers { get; set; }
        public virtual ICollection<SectionContactFooter> ContactFooter_DeleteUsers { get; set; }
        //CurrentlyShowing
        public virtual ICollection<SectionCurrentlyShowing> CurrentlyShowing_CreationUsers { get; set; }
        public virtual ICollection<SectionCurrentlyShowing> CurrentlyShowing_ModifyUsers { get; set; }
        public virtual ICollection<SectionCurrentlyShowing> CurrentlyShowing_DeleteUsers { get; set; }

        //CurrentlyShowingList
        public virtual ICollection<SectionCurrentlyShowingList> CurrentlyShowingList_CreationUsers { get; set; }
        public virtual ICollection<SectionCurrentlyShowingList> CurrentlyShowingList_ModifyUsers { get; set; }
        public virtual ICollection<SectionCurrentlyShowingList> CurrentlyShowingList_DeleteUsers { get; set; }

        //Dictionary
        public virtual ICollection<Dictionary> Dictionary_CreationUsers { get; set; }
        public virtual ICollection<Dictionary> Dictionary_ModifyUsers { get; set; }
        public virtual ICollection<Dictionary> Dictionary_DeleteUsers { get; set; }

        //Division
        public virtual ICollection<SectionDivision> Division_CreationUsers { get; set; }
        public virtual ICollection<SectionDivision> Division_ModifyUsers { get; set; }
        public virtual ICollection<SectionDivision> Division_DeleteUsers { get; set; }

        //Event
        public virtual ICollection<SectionEvent> Event_CreationUsers { get; set; }
        public virtual ICollection<SectionEvent> Event_ModifyUsers { get; set; }
        public virtual ICollection<SectionEvent> Event_DeleteUsers { get; set; }

        //EventList
        public virtual ICollection<SectionEventList> EventList_CreationUsers { get; set; }
        public virtual ICollection<SectionEventList> EventList_ModifyUsers { get; set; }
        public virtual ICollection<SectionEventList> EventList_DeleteUsers { get; set; }

        //Footer
        public virtual ICollection<SectionFooter> Footer_CreationUsers { get; set; }
        public virtual ICollection<SectionFooter> Footer_ModifyUsers { get; set; }
        public virtual ICollection<SectionFooter> Footer_DeleteUsers { get; set; }

        //Guild
        public virtual ICollection<SectionAssociation> Guild_CreationUsers { get; set; }
        public virtual ICollection<SectionAssociation> Guild_ModifyUsers { get; set; }
        public virtual ICollection<SectionAssociation> Guild_DeleteUsers { get; set; }

        //GuildFooter
        public virtual ICollection<SectionAssociationFooter> GuildFooter_CreationUsers { get; set; }
        public virtual ICollection<SectionAssociationFooter> GuildFooter_ModifyUsers { get; set; }
        public virtual ICollection<SectionAssociationFooter> GuildFooter_DeleteUsers { get; set; }

        //GuildMember
        public virtual ICollection<SectionAssociationMember> GuildMember_CreationUsers { get; set; }
        public virtual ICollection<SectionAssociationMember> GuildMember_ModifyUsers { get; set; }
        public virtual ICollection<SectionAssociationMember> GuildMember_DeleteUsers { get; set; }

        //Intro
        public virtual ICollection<SectionIntro> Intro_CreationUsers { get; set; }
        public virtual ICollection<SectionIntro> Intro_ModifyUsers { get; set; }
        public virtual ICollection<SectionIntro> Intro_DeleteUsers { get; set; }

        //Language
        public virtual ICollection<Language> Language_CreationUsers { get; set; }
        public virtual ICollection<Language> Language_ModifyUsers { get; set; }
        public virtual ICollection<Language> Language_DeleteUsers { get; set; }

        //LatestNew
        public virtual ICollection<SectionLatestNew> LatestNew_CreationUsers { get; set; }
        public virtual ICollection<SectionLatestNew> LatestNew_ModifyUsers { get; set; }
        public virtual ICollection<SectionLatestNew> LatestNew_DeleteUsers { get; set; }

        //LatestNewsList
        public virtual ICollection<SectionLatestNewList> LatestNewsList_CreationUsers { get; set; }
        public virtual ICollection<SectionLatestNewList> LatestNewsList_ModifyUsers { get; set; }
        public virtual ICollection<SectionLatestNewList> LatestNewsList_DeleteUsers { get; set; }

        //LatestService
        public virtual ICollection<SectionLatestService> LatestService_CreationUsers { get; set; }
        public virtual ICollection<SectionLatestService> LatestService_ModifyUsers { get; set; }
        public virtual ICollection<SectionLatestService> LatestService_DeleteUsers { get; set; }

        //LatestServiceList
        public virtual ICollection<SectionLatestServiceList> LatestServiceList_CreationUsers { get; set; }
        public virtual ICollection<SectionLatestServiceList> LatestServiceList_ModifyUsers { get; set; }
        public virtual ICollection<SectionLatestServiceList> LatestServiceList_DeleteUsers { get; set; }

        //Miscellaneous
        public virtual ICollection<Miscellaneous> Miscellaneous_CreationUsers { get; set; }
        public virtual ICollection<Miscellaneous> Miscellaneous_ModifyUsers { get; set; }
        public virtual ICollection<Miscellaneous> Miscellaneous_DeleteUsers { get; set; }

        //Service
        public virtual ICollection<SectionService> Service_CreationUsers { get; set; }
        public virtual ICollection<SectionService> Service_ModifyUsers { get; set; }
        public virtual ICollection<SectionService> Service_DeleteUsers { get; set; }

        //SyndicateCouncilWord
        public virtual ICollection<SectionAssociationCouncilWord> SyndicateCouncilWord_CreationUsers { get; set; }
        public virtual ICollection<SectionAssociationCouncilWord> SyndicateCouncilWord_ModifyUsers { get; set; }
        public virtual ICollection<SectionAssociationCouncilWord> SyndicateCouncilWord_DeleteUsers { get; set; }

        //SectionVisiblity
        public virtual ICollection<SectionVisiblity> SectionVisiblity_CreationUsers { get; set; }
        public virtual ICollection<SectionVisiblity> SectionVisiblity_ModifyUsers { get; set; }
        public virtual ICollection<SectionVisiblity> SectionVisiblity_DeleteUsers { get; set; }





    }
}
