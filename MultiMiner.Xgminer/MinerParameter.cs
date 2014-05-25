﻿namespace MultiMiner.Xgminer
{
    public static class MinerParameter
    {
        public const string ApiListen = "--api-listen";
        public const string EnumerateDevices = "--ndevs";
        public const string DeviceList = "--device ?";
        public const string ScanSerialAll = "--scan all";
        public const string ScanSerialErupterAll = "--scan erupter:all";
        public const string ScanSerialNanofuryAll = "--scan nanofury:all";
        public const string ScanSerialOpenCL = "--scan opencl:auto";
        public const string ScanSerialOpenCLNoAuto = "--scan opencl:noauto";
        public const string ScanSerialCpu = "--scan cpu:auto";
        public const string ScanSerialNoAuto = "--scan noauto";
        public const string ScanSerialAuto = "--scan auto";
        public const string Scrypt = "--scrypt";
        public const string ScryptVert = "--scrypt-vert";
        public const string AlgorithmNScrypt = "--algorithm nscrypt";
        public const string ScryptJane = "--scrypt-jane";
        public const string KernelDarkcoin = "--kernel darkcoin";
        public const string KernelQuarkcoin = "--kernel quarkcoin";
        public const string KernelGroestcoin = "--kernel groestlcoin";
        public const string Keccak = "--keccak";
    }
}
