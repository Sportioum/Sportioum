using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using MetaMask.Models;
using MetaMask.Unity;
using UnityEngine;



public class WalletManagerScript : MonoBehaviour
{
    public GameObject connectToWallet;
    public GameObject purchaseButton;
    MetaMask.MetaMaskWallet wallet;
    // Start is called before the first frame update
    void Start()
    {
        wallet = MetaMaskUnity.Instance.Wallet;
        wallet.WalletConnected += OnWalletConnected;
        wallet.WalletAuthorized += OnWalletAuthorized;

        if(PlayerPrefs.HasKey("walletIsConnected")==true)
        {
            connectToWallet.SetActive(false);
            purchaseButton.SetActive(true);
        }
        else
        {
            purchaseButton.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnWalletConnected(object sender, EventArgs e)
    {
        UnityEngine.Debug.Log("WalletIsConnected");
        PlayerPrefs.SetInt("WalletConnected", 1);
    }

    void OnWalletAuthorized(object sender, EventArgs e)
    {
        UnityEngine.Debug.Log("Wallet is authorized");

    }

    public void ConnectToWallet()
    {
        if (PlayerPrefs.HasKey("walletIsConnected") == false)
        {
            wallet.Connect();
        }
        else
        {
            UnityEngine.Debug.Log("Wallet is already connected");
           
        }

    }

    public void doPurchase(string SportioumAddress, string Amount)
    {
        purchaseNFT(SportioumAddress, Amount);
    }

    async Task purchaseNFT(string AthleteAddress, string Amount)
    {
        var transactionParams = new MetaMaskTransaction
        {
            To = AthleteAddress, //"0xd0059fB234f15dFA9371a7B45c09d451a2dd2B5a",
            From = MetaMaskUnity.Instance.Wallet.SelectedAddress,
            Value = Amount,
        };

        var request = new MetaMaskEthereumRequest
        {
            Method = "eth_sendTransaction",
            Parameters = new MetaMaskTransaction[] { transactionParams }
        };
        await wallet.Request(request);

        //transaction completed
        //NFT ownership transfer

    }



    }
