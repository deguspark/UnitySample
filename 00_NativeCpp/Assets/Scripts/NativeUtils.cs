using System.Runtime.InteropServices;

public class NativeUtils {

	[DllImport("__Internal")]
	private static extern int com_shogonir_Native_FourFours();

	public static int FourFours() {
		return com_shogonir_Native_FourFours();
	}
}
