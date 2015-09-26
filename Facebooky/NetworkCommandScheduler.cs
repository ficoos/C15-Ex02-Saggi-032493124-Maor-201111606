using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Facebooky
{
	public static class NetworkCommandScheduler
	{
		private static readonly List<ICommand> sr_ScheduledCommands = new List<ICommand>();

		static NetworkCommandScheduler()
		{
			NetworkChange.NetworkAvailabilityChanged += networkChange_NetworkAvailabilityChanged;
		}

		private static void networkChange_NetworkAvailabilityChanged(object i_Sender, NetworkAvailabilityEventArgs i_Args)
		{
			List<ICommand> commandsFinishedSuccessfuly = new List<ICommand>();
			foreach (ICommand command in sr_ScheduledCommands)
			{
				if (!NetworkInterface.GetIsNetworkAvailable())
				{
					break;
				}

				command.Execute();
				commandsFinishedSuccessfuly.Add(command);
			}

			foreach (ICommand command in commandsFinishedSuccessfuly)
			{
				sr_ScheduledCommands.Remove(command);
			}
		}

		public static void ScheduleOnNetworkAvailability(ICommand i_Command)
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				i_Command.Execute();
			}
			else
			{
				sr_ScheduledCommands.Add(i_Command);
			}
		}
	}
}
