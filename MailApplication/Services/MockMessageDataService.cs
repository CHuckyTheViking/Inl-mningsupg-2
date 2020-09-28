using MailApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailApplication.Services
{
    public class MockMessageDataService : IMessageDataService
    {
        private IEnumerable<MessageModel> _messageModels;

        public MockMessageDataService()
        {
            _messageModels = new List<MessageModel>()
            {
                new MessageModel
                {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Oscar.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Oscar Larsson",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"
                },
                 new MessageModel
                 {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Göran.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Göran Karlsson",
                    MessageHeadline = "What kind of language is used?",
                    Message = "IK-profilen dömd tillIK-profilen dömd tillIK-profilen dömd tillIK-profilen dömd till"
                 },
                  new MessageModel
                  {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kurt.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Kurt Svensson",
                    MessageHeadline = "Some practical ideas",
                    Message = "In the last six months, COVID-19 has changed almost everything about the way we approach work and security. Now, you have to meet the needs of a remote workforce, support rapidly evolving business requirements, and steer your organization to the next normal – even without actually knowing what that normal will entail. At the same time, cybersecurity is more crucial than ever, as bad actors exploit the opportunity to prey on fears and weaknesses."

                  },
                   new MessageModel
                   {
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Åsa Lagerblad",
                    MessageHeadline = "What kind of language is used?",
                    Message = "On the surface, all of this may seem intimidating. But with this kind of dramatic change also comes the opportunity to evolve. We know that the “new normal” now requires you to address a higher volume of security work than ever, all while remaining agile and reducing costs. How do you do that? By having a razor-sharp focus on what’s important. That’s why Microsoft Azure is here to empower you with cloud-native tools that give you the breadth of coverage you need to defend against bad actors, alongside built-in AI to help you focus your attentions on the biggest threats and most critical priorities."
                   },
                   new MessageModel
                   {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kalle.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Kalle Eriksson",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"                 
                   },
                   new MessageModel
                   {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Oscar.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Oscar Larsson",
                    MessageHeadline = "What is different about short",
                    Message = "Today, you need to detect threats across many different attack surfaces. XDR is an emerging industry category that describes the set of threat protection technologies that span endpoints, applications, networking, and cloud. Some vendors deliver an XDR, some vendors deliver a SIEM. Microsoft believes that you benefit from both the comprehensive nature of a SIEM and from the signal prioritization of XDR. Microsoft delivers one of the most comprehensive XDR capabilities in the market with user environment protection technologies like Microsoft Defender Advanced Threat Protection (ATP), Azure ATP, and Office 365 ATP, as well as infrastructure protection technologies like Azure Security Center Standard edition, Azure Security Center for IoT, and Advanced Threat Protection for SQL."
                   },
                   new MessageModel
                   {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kalle.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Kalle Eriksson",
                    MessageHeadline = "What is different about short",
                    Message = "Today we are simplifying and unifying our branding of these technologies under the unified brand of Microsoft Defender. Microsoft Defender includes Microsoft 365 Defender to protect user environments and Azure Defender for cloud workload protection of hybrid environments."
                   },
                   new MessageModel
                   {
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Åsa Lagerblad",
                    MessageHeadline = "What is different about short",
                    Message = "Azure Security Center for IoT is now rebranded as Azure Defender for IoT. In July, we announced the acquisition of CyberX to help protect industrial IoT, operational technology (OT) and building management system (BMS) environments."
                   }             
            };
        }
        public IEnumerable<MessageModel> GetMessageModels()
        {
            return _messageModels;
        }

        public void Save(IEnumerable<MessageModel> messageModels)
        {
            _messageModels = messageModels;
        }
    }
}
