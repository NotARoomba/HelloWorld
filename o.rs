use std::process::Command;
fn main() {
	println!("o");
	Command::new("go").arg("run").arg("s.go").spawn();
}