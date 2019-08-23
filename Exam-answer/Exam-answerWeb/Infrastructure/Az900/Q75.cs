
using DAL.Entities;
using System.Collections.Generic;

namespace Exam_answerWeb.Infrastructure.Questions
{
    public partial class Az900
    {
        public static QuestionEntity Q74Instance = new QuestionEntity()
        {
            QuestionType = QuestionType.RadioButon,
            Order = 198,
            Section = "",
            Contents = new List<ContentEntity>()
            {
                new ContentEntity()
                {
                    Text = "You have an Azure Active Directory (Azure AD) tenant that contains 5,000 user accounts.",
                },
                new ContentEntity()
                {
                    Text = "You create a new user account named AdminUser1.",
                },
                new ContentEntity()
                {
                    Text = "You need to assign the User administrator administrative role to AdminUser1.",
                },
                new ContentEntity()
                {
                    Text = "What should you do from the user account properties?",
                },
            },

            Answers = new List<AnswerEntity>()
            {
                new AnswerEntity()
                {
                    Text = "From the Directory role blade, modify the directory role.", 
                    IsCorrect = true
                },
                new AnswerEntity()
                {
                    Text = "From the Licenses blade, assign a new license.", 
                    IsCorrect = false
                },
                new AnswerEntity()
                {
                    Text = "From the Groups blade, invite the user account to a new group.", 
                    IsCorrect = false
                },
            },

            Explanations = new List<ExplanationEntity>()
            {
                new ExplanationEntity()
                {
                    Text = "Assign a role to a user"
                },
                new ExplanationEntity()
                {
                    Text = "1. Sign in to the Azure portal with an account that's a global admin or privileged role admin for the directory."
                },
                new ExplanationEntity()
                {
                    Text = "2. Select Azure Active Directory, select Users, and then select a specific user from the list."
                },
                new ExplanationEntity()
                {
                    Text = "3. For the selected user, select Directory role, select Add role, and then pick the appropriate admin roles from the Directory roles list, such as Conditional access"
                },
                new ExplanationEntity()
                {
                    Text = "administrator."
                },
                new ExplanationEntity()
                {
                    Text = "4. Press Select to save."
                },
            },

            References = new List<ReferenceEntity>()
            {
                new ReferenceEntity()
                {
                    Url = "https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-users-assign-role-azure-portal",
                },
            },           
        };
    }
}
