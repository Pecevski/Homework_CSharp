using System;
using System.Collections.Generic;
using AcademyApp.Entities;
using AcademyApp.Enums;

namespace AcademyApp.Helpers
{
    public class ParticipantHelper
    {
        // First parameter changed from array to List
        public static void FindParticipantByRole(List<Participant> participants, AcademyRole role)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var participant in participants)
            {
                if (participant.Role == role)
                    participant.PrintFullName();
            }
        }

    }
}