import java.io.File;

public class l {
	public static void main(String[] args) throws java.io.IOException, InterruptedException {
		System.out.println("l");
		Process p = Runtime.getRuntime().exec("/usr/local/bin/rustc ./o.rs");
		p.waitFor();
		p = new ProcessBuilder().inheritIO().command("./o").start();
	}
}