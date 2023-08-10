using System;

namespace Task4
{
	public abstract class CloseableResource
	{
		public void Close()
		{
		}
	}

	public class DisposePatternImplementer : CloseableResource, IDisposable
	{
		private bool disposed = false;

		public void Dispose()
		{
			Dispose(true);

			
			GC.SuppressFinalize(this);
		}

		

		~DisposePatternImplementer()
		{
			Dispose(false);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					
					Console.WriteLine("Disposing by developer");
				}
				else
				{ 
					Console.WriteLine("Disposing by GC");
				}

				
				Close();

				disposed = true;
			}
		}
	}
}
