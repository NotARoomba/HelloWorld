package main
import ("fmt"; "os/exec")
func main() {
  fmt.Println(" ")
	cmd := exec.Command("ruby", "w.rb")
	output, _ := cmd.CombinedOutput()
	fmt.Println(string(output))
}