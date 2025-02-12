﻿// <auto-generated />
using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(GSBGMFinalContext))]
    [Migration("20190618015939_SecondCreate")]
    partial class SecondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.BGLocation", b =>
                {
                    b.Property<int>("Lid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Lid")
                        .HasName("PK_BGLocation_ID");

                    b.ToTable("BGLocation");
                });

            modelBuilder.Entity("Data.Models.BGUser", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowEN")
                        .HasColumnName("AllowEN");

                    b.Property<bool>("AllowPN")
                        .HasColumnName("AllowPN");

                    b.Property<DateTime>("DoB")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int?>("Lid")
                        .HasColumnName("LID");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("PASSWORD")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Uid")
                        .HasName("PK_User_ID");

                    b.HasIndex("Lid");

                    b.ToTable("BGUser");
                });

            modelBuilder.Entity("Data.Models.BoardGame", b =>
                {
                    b.Property<int>("Gid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BggId")
                        .HasColumnName("BGG_ID");

                    b.Property<double?>("Bggrating")
                        .HasColumnName("BGGRating");

                    b.Property<string>("Bgname")
                        .IsRequired()
                        .HasColumnName("BGName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("MaxPlayerCount");

                    b.Property<string>("Mechanics")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int>("MinPlayerCount");

                    b.Property<int?>("PlayTime");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnName("ThumbnailURL")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Gid")
                        .HasName("PK_BoardGame_ID");

                    b.ToTable("BoardGame");
                });

            modelBuilder.Entity("Data.Models.Friend", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Uid1")
                        .HasColumnName("UID1");

                    b.Property<int>("Uid2")
                        .HasColumnName("UID2");

                    b.HasKey("Fid")
                        .HasName("PK_Friend_ID");

                    b.HasIndex("Uid1");

                    b.HasIndex("Uid2");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("Data.Models.FriendInvitation", b =>
                {
                    b.Property<int>("Fiid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FIID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReceiverUid")
                        .HasColumnName("ReceiverUID");

                    b.Property<int>("SenderUid")
                        .HasColumnName("SenderUID");

                    b.HasKey("Fiid")
                        .HasName("PK_FriendInvitation_ID");

                    b.HasIndex("ReceiverUid");

                    b.HasIndex("SenderUid");

                    b.ToTable("FriendInvitation");
                });

            modelBuilder.Entity("Data.Models.Meeting", b =>
                {
                    b.Property<int>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Gid")
                        .HasColumnName("GID");

                    b.Property<int>("HostUid")
                        .HasColumnName("HostUID");

                    b.Property<int>("Lid")
                        .HasColumnName("LID");

                    b.HasKey("Mid")
                        .HasName("PK_Meeting_ID");

                    b.HasIndex("Gid");

                    b.HasIndex("HostUid");

                    b.HasIndex("Lid");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("Data.Models.MeetingInvitation", b =>
                {
                    b.Property<int>("Miid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MIID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InitiatorUid")
                        .HasColumnName("InitiatorUID");

                    b.Property<int>("Mid")
                        .HasColumnName("MID");

                    b.Property<int>("ReceiverUid")
                        .HasColumnName("ReceiverUID");

                    b.HasKey("Miid")
                        .HasName("PK_MeetingInvitation_ID");

                    b.HasIndex("InitiatorUid");

                    b.HasIndex("Mid");

                    b.HasIndex("ReceiverUid");

                    b.ToTable("MeetingInvitation");
                });

            modelBuilder.Entity("Data.Models.MeetingMenber", b =>
                {
                    b.Property<int>("Umid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UMID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mid")
                        .HasColumnName("MID");

                    b.Property<int>("Uid")
                        .HasColumnName("UID");

                    b.HasKey("Umid")
                        .HasName("PK_UserMeeting_ID");

                    b.HasIndex("Mid");

                    b.HasIndex("Uid");

                    b.ToTable("UserMeeting");
                });

            modelBuilder.Entity("Data.Models.MeetingRequest", b =>
                {
                    b.Property<int>("Mrid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MRID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Gid")
                        .HasColumnName("GID");

                    b.Property<int>("InitiatorUid")
                        .HasColumnName("InitiatorUID");

                    b.Property<int>("Lid")
                        .HasColumnName("LID");

                    b.Property<int>("ReceiverUid")
                        .HasColumnName("ReceiverUID");

                    b.HasKey("Mrid")
                        .HasName("PK_MeetingRequest_ID");

                    b.HasIndex("Gid");

                    b.HasIndex("InitiatorUid");

                    b.HasIndex("Lid");

                    b.HasIndex("ReceiverUid");

                    b.ToTable("MeetingRequest");
                });

            modelBuilder.Entity("Data.Models.Rating", b =>
                {
                    b.Property<int>("Rid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mid")
                        .HasColumnName("MID");

                    b.Property<int>("Rating1")
                        .HasColumnName("Rating");

                    b.Property<int>("RatingUid")
                        .HasColumnName("RatingUID");

                    b.Property<int>("SurveyTakerUid")
                        .HasColumnName("SurveyTakerUID");

                    b.HasKey("Rid")
                        .HasName("PK_Rating_ID");

                    b.HasIndex("Mid");

                    b.HasIndex("RatingUid");

                    b.HasIndex("SurveyTakerUid");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Data.Models.UserCollection", b =>
                {
                    b.Property<int>("Ucid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UCID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gid")
                        .HasColumnName("GID");

                    b.Property<int>("Uid")
                        .HasColumnName("UID");

                    b.HasKey("Ucid")
                        .HasName("PK_UserCollection_ID");

                    b.HasIndex("Gid");

                    b.HasIndex("Uid");

                    b.ToTable("UserCollection");
                });

            modelBuilder.Entity("Data.Models.BGUser", b =>
                {
                    b.HasOne("Data.Models.BGLocation", "L")
                        .WithMany("BGUser")
                        .HasForeignKey("Lid")
                        .HasConstraintName("FK_PreferedLocation_ID");
                });

            modelBuilder.Entity("Data.Models.Friend", b =>
                {
                    b.HasOne("Data.Models.BGUser", "Uid1Navigation")
                        .WithMany("FriendUid1Navigation")
                        .HasForeignKey("Uid1")
                        .HasConstraintName("FK_FriendUser1_ID");

                    b.HasOne("Data.Models.BGUser", "Uid2Navigation")
                        .WithMany("FriendUid2Navigation")
                        .HasForeignKey("Uid2")
                        .HasConstraintName("FK_FriendUser2_ID");
                });

            modelBuilder.Entity("Data.Models.FriendInvitation", b =>
                {
                    b.HasOne("Data.Models.BGUser", "ReceiverU")
                        .WithMany("FriendInvitationReceiverU")
                        .HasForeignKey("ReceiverUid")
                        .HasConstraintName("FK_FIReceiver_ID");

                    b.HasOne("Data.Models.BGUser", "SenderU")
                        .WithMany("FriendInvitationSenderU")
                        .HasForeignKey("SenderUid")
                        .HasConstraintName("FK_FISender_ID");
                });

            modelBuilder.Entity("Data.Models.Meeting", b =>
                {
                    b.HasOne("Data.Models.BoardGame", "G")
                        .WithMany("Meeting")
                        .HasForeignKey("Gid")
                        .HasConstraintName("FK_MeetingBoardGame_ID");

                    b.HasOne("Data.Models.BGUser", "HostU")
                        .WithMany("Meeting")
                        .HasForeignKey("HostUid")
                        .HasConstraintName("FK_HostUser_ID");

                    b.HasOne("Data.Models.BGLocation", "L")
                        .WithMany("Meeting")
                        .HasForeignKey("Lid")
                        .HasConstraintName("FK_MeetingLocation_ID");
                });

            modelBuilder.Entity("Data.Models.MeetingInvitation", b =>
                {
                    b.HasOne("Data.Models.BGUser", "InitiatorU")
                        .WithMany("MeetingInvitationInitiatorU")
                        .HasForeignKey("InitiatorUid")
                        .HasConstraintName("FK_MIInitiator_ID");

                    b.HasOne("Data.Models.Meeting", "M")
                        .WithMany("MeetingInvitation")
                        .HasForeignKey("Mid")
                        .HasConstraintName("FK_MIMeeting_ID");

                    b.HasOne("Data.Models.BGUser", "ReceiverU")
                        .WithMany("MeetingInvitationReceiverU")
                        .HasForeignKey("ReceiverUid")
                        .HasConstraintName("FK_MIReceiver_ID");
                });

            modelBuilder.Entity("Data.Models.MeetingMenber", b =>
                {
                    b.HasOne("Data.Models.Meeting", "M")
                        .WithMany("MeetingMenber")
                        .HasForeignKey("Mid")
                        .HasConstraintName("FK_UMMeeting_ID");

                    b.HasOne("Data.Models.BGUser", "U")
                        .WithMany("MeetingMenber")
                        .HasForeignKey("Uid")
                        .HasConstraintName("FK_UMUser_ID");
                });

            modelBuilder.Entity("Data.Models.MeetingRequest", b =>
                {
                    b.HasOne("Data.Models.BoardGame", "G")
                        .WithMany("MeetingRequest")
                        .HasForeignKey("Gid")
                        .HasConstraintName("FK_MRBoardGame_ID");

                    b.HasOne("Data.Models.BGUser", "InitiatorU")
                        .WithMany("MeetingRequestInitiatorU")
                        .HasForeignKey("InitiatorUid")
                        .HasConstraintName("FK_MRInitiator_ID");

                    b.HasOne("Data.Models.BGLocation", "L")
                        .WithMany("MeetingRequest")
                        .HasForeignKey("Lid")
                        .HasConstraintName("FK_MRLocaiton_ID");

                    b.HasOne("Data.Models.BGUser", "ReceiverU")
                        .WithMany("MeetingRequestReceiverU")
                        .HasForeignKey("ReceiverUid")
                        .HasConstraintName("FK_MRReceiver_ID");
                });

            modelBuilder.Entity("Data.Models.Rating", b =>
                {
                    b.HasOne("Data.Models.Meeting", "M")
                        .WithMany("Rating")
                        .HasForeignKey("Mid")
                        .HasConstraintName("FK_RatingMeeting_ID");

                    b.HasOne("Data.Models.BGUser", "RatingU")
                        .WithMany("RatingRatingU")
                        .HasForeignKey("RatingUid")
                        .HasConstraintName("FK_RatingUID_ID");

                    b.HasOne("Data.Models.BGUser", "SurveyTakerU")
                        .WithMany("RatingSurveyTakerU")
                        .HasForeignKey("SurveyTakerUid")
                        .HasConstraintName("FK_SurveyTakerUID_ID");
                });

            modelBuilder.Entity("Data.Models.UserCollection", b =>
                {
                    b.HasOne("Data.Models.BoardGame", "G")
                        .WithMany("UserCollection")
                        .HasForeignKey("Gid")
                        .HasConstraintName("FK_UCBoardGame_ID");

                    b.HasOne("Data.Models.BGUser", "U")
                        .WithMany("UserCollection")
                        .HasForeignKey("Uid")
                        .HasConstraintName("FK_UCUser_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
