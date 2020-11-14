﻿// <auto-generated />
using BlazorWorld.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorWorld.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BlazorWorld.Core.Entities.Common.EntityCustomFields", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField1")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField10")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField11")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField12")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField13")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField14")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField15")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField16")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField17")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField18")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField19")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField2")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField20")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField3")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField4")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField5")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField6")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField7")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField8")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomField9")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField1")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField10")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField11")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField12")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField13")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField14")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField15")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField16")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField17")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField18")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField19")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField2")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField20")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField3")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField4")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField5")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField6")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField7")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField8")
                        .HasColumnType("TEXT");

                    b.Property<string>("IndexedCustomField9")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("IndexedCustomField1");

                    b.HasIndex("IndexedCustomField10");

                    b.HasIndex("IndexedCustomField11");

                    b.HasIndex("IndexedCustomField12");

                    b.HasIndex("IndexedCustomField13");

                    b.HasIndex("IndexedCustomField14");

                    b.HasIndex("IndexedCustomField15");

                    b.HasIndex("IndexedCustomField16");

                    b.HasIndex("IndexedCustomField17");

                    b.HasIndex("IndexedCustomField18");

                    b.HasIndex("IndexedCustomField19");

                    b.HasIndex("IndexedCustomField2");

                    b.HasIndex("IndexedCustomField20");

                    b.HasIndex("IndexedCustomField3");

                    b.HasIndex("IndexedCustomField4");

                    b.HasIndex("IndexedCustomField5");

                    b.HasIndex("IndexedCustomField6");

                    b.HasIndex("IndexedCustomField7");

                    b.HasIndex("IndexedCustomField8");

                    b.HasIndex("IndexedCustomField9");

                    b.ToTable("EntityCustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Configuration.Permission", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Module", "Type", "Action");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Configuration.Setting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Object")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Activity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("NodeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("NodeId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.EntityTag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("BadgeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EntityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupMemberId")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvitationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NodeVoteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReactionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SettingId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("BadgeId");

                    b.HasIndex("EntityId");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupMemberId");

                    b.HasIndex("InvitationId");

                    b.HasIndex("MessageId");

                    b.HasIndex("NodeVoteId");

                    b.HasIndex("ReactionId");

                    b.HasIndex("SettingId");

                    b.HasIndex("SiteId");

                    b.HasIndex("Tag");

                    b.ToTable("EntityTags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Message", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Module")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("GroupId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Node", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<int>("DescendantCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DownVotes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Hot")
                        .HasColumnType("REAL");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UpVotes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ParentId");

                    b.HasIndex("Slug");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.NodeVersion", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("NodeId");

                    b.ToTable("NodeVersions");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.NodeVote", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("NodeId");

                    b.HasIndex("NodeId", "UserId");

                    b.ToTable("NodeVotes");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Reaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReactionType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("ContentId", "UserId");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Badge", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("UserId");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Group", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Module")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.GroupMember", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupId", "UserId");

                    b.ToTable("GroupMembers");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Invitation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InvitationCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("Email");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Site", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomFieldsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomFieldsId");

                    b.HasIndex("TenantId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Configuration.Setting", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Activity", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.EntityTag", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Content.Activity", null)
                        .WithMany("Tags")
                        .HasForeignKey("ActivityId");

                    b.HasOne("BlazorWorld.Core.Entities.Organization.Badge", null)
                        .WithMany("Tags")
                        .HasForeignKey("BadgeId");

                    b.HasOne("BlazorWorld.Core.Entities.Organization.Group", null)
                        .WithMany("Tags")
                        .HasForeignKey("GroupId");

                    b.HasOne("BlazorWorld.Core.Entities.Organization.GroupMember", null)
                        .WithMany("Tags")
                        .HasForeignKey("GroupMemberId");

                    b.HasOne("BlazorWorld.Core.Entities.Organization.Invitation", null)
                        .WithMany("Tags")
                        .HasForeignKey("InvitationId");

                    b.HasOne("BlazorWorld.Core.Entities.Content.Message", null)
                        .WithMany("Tags")
                        .HasForeignKey("MessageId");

                    b.HasOne("BlazorWorld.Core.Entities.Content.NodeVote", null)
                        .WithMany("Tags")
                        .HasForeignKey("NodeVoteId");

                    b.HasOne("BlazorWorld.Core.Entities.Content.Reaction", null)
                        .WithMany("Tags")
                        .HasForeignKey("ReactionId");

                    b.HasOne("BlazorWorld.Core.Entities.Configuration.Setting", null)
                        .WithMany("Tags")
                        .HasForeignKey("SettingId");

                    b.HasOne("BlazorWorld.Core.Entities.Organization.Site", null)
                        .WithMany("Tags")
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Message", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Node", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.NodeVersion", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.NodeVote", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Reaction", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Badge", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Group", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.GroupMember", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Invitation", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Site", b =>
                {
                    b.HasOne("BlazorWorld.Core.Entities.Common.EntityCustomFields", "CustomFields")
                        .WithMany()
                        .HasForeignKey("CustomFieldsId");

                    b.Navigation("CustomFields");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Configuration.Setting", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Activity", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Message", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.NodeVote", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Content.Reaction", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Badge", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Group", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.GroupMember", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Invitation", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("BlazorWorld.Core.Entities.Organization.Site", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
