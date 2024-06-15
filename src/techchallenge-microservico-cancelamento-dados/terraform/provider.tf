terraform {
  backend "s3" {
    bucket = "terraform-tfstates-totem-eks-cancelamento-dados"
    key    = "totemLanchoneteEKS/terraform.tfstate"
    region = "us-east-1"
  }
}