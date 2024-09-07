﻿// <auto-generated />
using System;
using MessengerAPI.Infrastructure.Common.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessengerAPI.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MessageAttachments", b =>
                {
                    b.Property<int>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("FileDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("MessageId", "FileDataId");

                    b.HasIndex("FileDataId");

                    b.ToTable("MessageAttachments");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Channel.Channel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LastMessageId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("LastMessageId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Channel.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ChannelId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReplyTo")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("SenderId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Common.Entities.FileData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Sha256")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<long>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UploadedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Common.Entities.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Emoji")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReactionGroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReactionGroupId");

                    b.ToTable("Reaction");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Common.Entities.ReactionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReactionGroups");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.Entities.ProfilePhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("FileId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FileId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("ProfilePhoto");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.Entities.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUsedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TokenId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("GlobalName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PasswordUpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("TerminateSessions")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TwoFactorAuthentication")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UsernameUpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MessageAttachments", b =>
                {
                    b.HasOne("MessengerAPI.Domain.Common.Entities.FileData", null)
                        .WithMany()
                        .HasForeignKey("FileDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessengerAPI.Domain.Channel.Entities.Message", null)
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MessengerAPI.Domain.Channel.Channel", b =>
                {
                    b.HasOne("MessengerAPI.Domain.Common.Entities.FileData", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("MessengerAPI.Domain.Channel.Entities.Message", null)
                        .WithMany()
                        .HasForeignKey("LastMessageId");

                    b.HasOne("MessengerAPI.Domain.User.User", null)
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.OwnsMany("MessengerAPI.Domain.Channel.ValueObjects.AdminId", "AdminIds", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("TEXT")
                                .HasColumnName("UserId");

                            b1.Property<Guid>("ChannelId")
                                .HasColumnType("TEXT");

                            b1.HasKey("UserId", "ChannelId");

                            b1.HasIndex("ChannelId");

                            b1.ToTable("ChannelAdminIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ChannelId");

                            b1.HasOne("MessengerAPI.Domain.User.User", null)
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                    b.OwnsMany("MessengerAPI.Domain.Channel.ValueObjects.MemberId", "MemberIds", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("TEXT")
                                .HasColumnName("UserId");

                            b1.Property<Guid>("ChannelId")
                                .HasColumnType("TEXT");

                            b1.HasKey("UserId", "ChannelId");

                            b1.HasIndex("ChannelId");

                            b1.ToTable("ChannelMemberIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ChannelId");

                            b1.HasOne("MessengerAPI.Domain.User.User", null)
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                    b.OwnsMany("MessengerAPI.Domain.Channel.ValueObjects.PinnedMessageId", "PinnedMessageIds", b1 =>
                        {
                            b1.Property<int>("MessageId")
                                .HasColumnType("INTEGER")
                                .HasColumnName("MessageId");

                            b1.Property<Guid>("ChannelId")
                                .HasColumnType("TEXT");

                            b1.HasKey("MessageId", "ChannelId");

                            b1.HasIndex("ChannelId");

                            b1.ToTable("PinnedMessageIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ChannelId");

                            b1.HasOne("MessengerAPI.Domain.Channel.Entities.Message", null)
                                .WithMany()
                                .HasForeignKey("MessageId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                    b.Navigation("AdminIds");

                    b.Navigation("Image");

                    b.Navigation("MemberIds");

                    b.Navigation("PinnedMessageIds");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Channel.Entities.Message", b =>
                {
                    b.HasOne("MessengerAPI.Domain.Channel.Channel", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessengerAPI.Domain.User.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("MessengerAPI.Domain.Channel.ValueObjects.UserReaction", "Reactions", b1 =>
                        {
                            b1.Property<int>("MessageId")
                                .HasColumnType("INTEGER");

                            b1.Property<Guid>("UserId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("ReactionId")
                                .HasColumnType("INTEGER");

                            b1.Property<DateTime>("Timestamp")
                                .HasColumnType("TEXT");

                            b1.HasKey("MessageId", "UserId");

                            b1.HasIndex("ReactionId");

                            b1.HasIndex("UserId");

                            b1.ToTable("UserReactions", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("MessageId");

                            b1.HasOne("MessengerAPI.Domain.Common.Entities.Reaction", "Reaction")
                                .WithMany()
                                .HasForeignKey("ReactionId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.HasOne("MessengerAPI.Domain.User.User", "User")
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.Navigation("Reaction");

                            b1.Navigation("User");
                        });

                    b.Navigation("Reactions");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Common.Entities.Reaction", b =>
                {
                    b.HasOne("MessengerAPI.Domain.Common.Entities.ReactionGroup", null)
                        .WithMany("Reactions")
                        .HasForeignKey("ReactionGroupId");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.Entities.ProfilePhoto", b =>
                {
                    b.HasOne("MessengerAPI.Domain.Common.Entities.FileData", "File")
                        .WithOne()
                        .HasForeignKey("MessengerAPI.Domain.User.Entities.ProfilePhoto", "FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessengerAPI.Domain.User.User", null)
                        .WithMany("ProfilePhotos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.Entities.Session", b =>
                {
                    b.HasOne("MessengerAPI.Domain.User.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.User", b =>
                {
                    b.OwnsMany("MessengerAPI.Domain.User.ValueObjects.Email", "Emails", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<DateTime>("AddedAt")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Data")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<bool>("IsPublic")
                                .HasColumnType("INTEGER");

                            b1.Property<bool>("IsVerified")
                                .HasColumnType("INTEGER");

                            b1.Property<Guid>("UserId")
                                .HasColumnType("TEXT");

                            b1.HasKey("Id");

                            b1.HasIndex("Data")
                                .IsUnique();

                            b1.HasIndex("UserId");

                            b1.ToTable("Email");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsMany("MessengerAPI.Domain.User.ValueObjects.Phone", "Phones", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<DateTime>("AddedAt")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Data")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<bool>("IsVerified")
                                .HasColumnType("INTEGER");

                            b1.Property<Guid>("UserId")
                                .HasColumnType("TEXT");

                            b1.HasKey("Id");

                            b1.HasIndex("Data")
                                .IsUnique();

                            b1.HasIndex("UserId");

                            b1.ToTable("Phone");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Emails");

                    b.Navigation("Phones");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Channel.Channel", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MessengerAPI.Domain.Common.Entities.ReactionGroup", b =>
                {
                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("MessengerAPI.Domain.User.User", b =>
                {
                    b.Navigation("ProfilePhotos");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
