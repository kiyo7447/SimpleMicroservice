@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ docker build -t simpleapi:latest .
ERROR: Cannot connect to the Docker daemon at unix:///var/run/docker.sock. Is the docker daemon running?

@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ systemctl status docker

"systemd" is not running in this container due to its overhead.
Use the "service" command to start services instead. e.g.: 

service --status-all
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ service --status-all
 [ ? ]  binfmt-support
 [ - ]  dbus
 [ ? ]  hwclock.sh
 [ - ]  procps
 [ - ]  rsync
 [ + ]  ssh
 [ - ]  x11-common

・・・う～ん。GitHub Actionsでbuild～Publishまでを実施したほうが良いのかなぁ

@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ echo $SHELL
/bin/bash
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ ls /etc
ODBCDataSources         binfmt.d              debian_version  fstab      hostname     ld.so.conf.d   lynx            nanorc         profile    rcS.d        ssh          timezone
PackageKit              ca-certificates       default         gai.conf   hosts        ldap           machine-id      networks       profile.d  resolv.conf  ssl          tmpfiles.d
X11                     ca-certificates.conf  deluser.conf    gdb        hosts.allow  legal          magic           nsswitch.conf  protocols  rmt          subgid       ucf.conf
adduser.conf            calendar              dhcp            gitconfig  hosts.deny   libaudit.conf  magic.mime      odbc.ini       python3    rpc          subgid-      ufw
alternatives            cloud                 docker          groff      init.d       lighttpd       mailcap         opt            python3.8  rvmrc        subuid       update-motd.d
apache2                 cron.d                dpkg            group      inputrc      locale.alias   mailcap.order   os-release     rc0.d      security     subuid-      vim
apparmor.d              cron.daily            e2scrub.conf    group-     iproute2     locale.gen     manpath.config  pam.conf       rc1.d      selinux      sudoers      wgetrc
apt                     cron.weekly           emacs           gshadow    issue        localtime      mime.types      pam.d          rc2.d      services     sudoers.d    xattr.conf
bash.bashrc             csh.login             environment     gshadow-   issue.net    logcheck       mke2fs.conf     passwd         rc3.d      shadow       sysctl.conf  xdg
bash_completion         dbus-1                ethertypes      gss        kernel       login.defs     modules-load.d  passwd-        rc4.d      shadow-      sysctl.d     zsh
bash_completion.d       dconf                 fish            gtk-3.0    ld.so.cache  logrotate.d    mtab            perl           rc5.d      shells       systemd      zshrc
bindresvport.blacklist  debconf.conf          fonts           host.conf  ld.so.conf   lsb-release    mysql           polkit-1       rc6.d      skel         terminfo
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ cat hostname
cat: hostname: No such file or directory
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ cat /etc/hostname
codespaces-b534dd
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ lsb_release
No LSB modules are available.
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ lsb_release -a
No LSB modules are available.
Distributor ID: Ubuntu
Description:    Ubuntu 20.04.6 LTS
Release:        20.04
Codename:       focal
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ uname -r
5.15.0-1041-azure
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ uname -a
Linux codespaces-b534dd 5.15.0-1041-azure #48-Ubuntu SMP Tue Jun 20 20:34:08 UTC 2023 x86_64 x86_64 x86_64 GNU/Linux
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ mount | grep cgroup
cgroup on /sys/fs/cgroup type cgroup2 (rw,nosuid,nodev,noexec,relatime,nsdelegate,memory_recursiveprot)
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ dmesg
dmesg: read kernel buffer failed: Operation not permitted
@kiyo7447 ➜ /workspaces/SimpleMicroservice/SimpleAPI/SimpleAPI (main) $ sudo dmesg
[    0.000000] Linux version 5.15.0-1041-azure (buildd@lcy02-amd64-062) (gcc (Ubuntu 11.3.0-1ubuntu1~22.04.1) 11.3.0, GNU ld (GNU Binutils for Ubuntu) 2.38) #48-Ubuntu SMP Tue Jun 20 20:34:08 UTC 2023 (Ubuntu 5.15.0-1041.48-azure 5.15.99)
[    0.000000] Command line: BOOT_IMAGE=/boot/vmlinuz-5.15.0-1041-azure root=PARTUUID=886ad3da-e4ec-442e-b223-03e615c2b78d ro console=tty1 console=ttyS0 earlyprintk=ttyS0 panic=-1
[    0.000000] KERNEL supported cpus:
[    0.000000]   Intel GenuineIntel
[    0.000000]   AMD AuthenticAMD
[    0.000000]   Hygon HygonGenuine
[    0.000000]   Centaur CentaurHauls
[    0.000000]   zhaoxin   Shanghai  
[    0.000000] x86/fpu: Supporting XSAVE feature 0x001: 'x87 floating point registers'
[    0.000000] x86/fpu: Supporting XSAVE feature 0x002: 'SSE registers'
[    0.000000] x86/fpu: Supporting XSAVE feature 0x004: 'AVX registers'
[    0.000000] x86/fpu: xstate_offset[2]:  576, xstate_sizes[2]:  256
[    0.000000] x86/fpu: Enabled xstate features 0x7, context size is 832 bytes, using 'compacted' format.
[    0.000000] signal: max sigframe size: 1776
[    0.000000] BIOS-provided physical RAM map:
[    0.000000] BIOS-e820: [mem 0x0000000000000000-0x000000000009fbff] usable
[    0.000000] BIOS-e820: [mem 0x000000000009fc00-0x000000000009ffff] reserved
[    0.000000] BIOS-e820: [mem 0x00000000000e0000-0x00000000000fffff] reserved
[    0.000000] BIOS-e820: [mem 0x0000000000100000-0x000000003ffeffff] usable
[    0.000000] BIOS-e820: [mem 0x000000003fff0000-0x000000003fffefff] ACPI data
[    0.000000] BIOS-e820: [mem 0x000000003ffff000-0x000000003fffffff] ACPI NVS
[    0.000000] BIOS-e820: [mem 0x0000000100000000-0x00000002bfffffff] usable
[    0.000000] printk: bootconsole [earlyser0] enabled
[    0.000000] NX (Execute Disable) protection: active
[    0.000000] SMBIOS 2.3 present.
[    0.000000] DMI: Microsoft Corporation Virtual Machine/Virtual Machine, BIOS 090008  12/07/2018
[    0.000000] Hypervisor detected: Microsoft Hyper-V
[    0.000000] Hyper-V: privilege flags low 0xae7f, high 0x388030, hints 0x140c2c, misc 0xc0bed7b2
[    0.000000] Hyper-V Host Build:20348-10.0-2-0.2762
[    0.000000] Hyper-V: Nested features: 0x4a0000
[    0.000000] Hyper-V: LAPIC Timer Frequency: 0xc3500
[    0.000000] Hyper-V: Using hypercall for remote TLB flush
[    0.000000] clocksource: hyperv_clocksource_tsc_page: mask: 0xffffffffffffffff max_cycles: 0x24e6a1710, max_idle_ns: 440795202120 ns
[    0.000003] tsc: Detected 2445.432 MHz processor
[    0.002664] e820: update [mem 0x00000000-0x00000fff] usable ==> reserved
[    0.002666] e820: remove [mem 0x000a0000-0x000fffff] usable
[    0.002670] last_pfn = 0x2c0000 max_arch_pfn = 0x400000000
[    0.005347] x86/PAT: Configuration [0-7]: WB  WC  UC- UC  WB  WP  UC- WT  
[    0.008772] e820: update [mem 0x40000000-0xffffffff] usable ==> reserved
[    0.010301] last_pfn = 0x3fff0 max_arch_pfn = 0x400000000
[    0.016443] found SMP MP-table at [mem 0x000ff780-0x000ff78f]
[    0.019114] Using GB pages for direct mapping
[    0.021113] ACPI: Early table checksum verification disabled
[    0.023656] ACPI: RSDP 0x00000000000F5C00 000014 (v00 ACPIAM)
[    0.026227] ACPI: RSDT 0x000000003FFF0000 000040 (v01 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.030009] ACPI: FACP 0x000000003FFF0200 000081 (v02 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.033891] ACPI: DSDT 0x000000003FFF1D24 003CD5 (v01 MSFTVM MSFTVM02 00000002 INTL 02002026)
[    0.037747] ACPI: FACS 0x000000003FFFF000 000040
[    0.039807] ACPI: WAET 0x000000003FFF1A80 000028 (v01 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.043653] ACPI: SLIC 0x000000003FFF1AC0 000176 (v01 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.047601] ACPI: OEM0 0x000000003FFF1CC0 000064 (v01 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.051476] ACPI: SRAT 0x000000003FFF0800 000140 (v02 VRTUAL MICROSFT 00000001 MSFT 00000001)
[    0.055296] ACPI: APIC 0x000000003FFF0300 000062 (v01 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.059226] ACPI: OEMB 0x000000003FFFF040 000064 (v01 VRTUAL MICROSFT 12001807 MSFT 00000097)
[    0.063351] ACPI: Reserving FACP table memory at [mem 0x3fff0200-0x3fff0280]
[    0.066737] ACPI: Reserving DSDT table memory at [mem 0x3fff1d24-0x3fff59f8]
[    0.070125] ACPI: Reserving FACS table memory at [mem 0x3ffff000-0x3ffff03f]
[    0.073531] ACPI: Reserving WAET table memory at [mem 0x3fff1a80-0x3fff1aa7]
[    0.076769] ACPI: Reserving SLIC table memory at [mem 0x3fff1ac0-0x3fff1c35]
[    0.081547] ACPI: Reserving OEM0 table memory at [mem 0x3fff1cc0-0x3fff1d23]
[    0.084753] ACPI: Reserving SRAT table memory at [mem 0x3fff0800-0x3fff093f]
[    0.087923] ACPI: Reserving APIC table memory at [mem 0x3fff0300-0x3fff0361]
[    0.091082] ACPI: Reserving OEMB table memory at [mem 0x3ffff040-0x3ffff0a3]
[    0.094386] SRAT: PXM 0 -> APIC 0x00 -> Node 0
[    0.096362] SRAT: PXM 0 -> APIC 0x01 -> Node 0
[    0.098330] ACPI: SRAT: Node 0 PXM 0 [mem 0x00000000-0x3fffffff] hotplug
[    0.101304] ACPI: SRAT: Node 0 PXM 0 [mem 0x100000000-0x2bfffffff] hotplug
[    0.104369] ACPI: SRAT: Node 0 PXM 0 [mem 0x2c0000000-0xfbfffffff] hotplug
[    0.107416] ACPI: SRAT: Node 0 PXM 0 [mem 0x1000000000-0xfcffffffff] hotplug
[    0.110687] ACPI: SRAT: Node 0 PXM 0 [mem 0x10000000000-0x1ffffffffff] hotplug
[    0.113904] ACPI: SRAT: Node 0 PXM 0 [mem 0x20000000000-0x3ffffffffff] hotplug
[    0.117111] NUMA: Node 0 [mem 0x00000000-0x3fffffff] + [mem 0x100000000-0x2bfffffff] -> [mem 0x00000000-0x2bfffffff]
[    0.121804] NODE_DATA(0) allocated [mem 0x2bffd6000-0x2bfffffff]
[    0.124733] Zone ranges:
[    0.125855]   DMA      [mem 0x0000000000001000-0x0000000000ffffff]
[    0.129779]   DMA32    [mem 0x0000000001000000-0x00000000ffffffff]
[    0.133095]   Normal   [mem 0x0000000100000000-0x00000002bfffffff]
[    0.135923]   Device   empty
[    0.137189] Movable zone start for each node
[    0.139075] Early memory node ranges
[    0.140657]   node   0: [mem 0x0000000000001000-0x000000000009efff]
[    0.143564]   node   0: [mem 0x0000000000100000-0x000000003ffeffff]
[    0.146481]   node   0: [mem 0x0000000100000000-0x00000002bfffffff]
[    0.149352] Initmem setup node 0 [mem 0x0000000000001000-0x00000002bfffffff]
[    0.152561] On node 0, zone DMA: 1 pages in unavailable ranges
[    0.152582] On node 0, zone DMA: 97 pages in unavailable ranges
[    0.164765] On node 0, zone Normal: 16 pages in unavailable ranges
[    0.169125] ACPI: PM-Timer IO Port: 0x408
[    0.173698] software IO TLB: swiotlb: Using 2 areas
[    0.176141] ACPI: LAPIC_NMI (acpi_id[0xff] dfl dfl lint[0x1])
[    0.179051] IOAPIC[0]: apic_id 0, version 17, address 0xfec00000, GSI 0-23
[    0.182125] ACPI: INT_SRC_OVR (bus 0 bus_irq 0 global_irq 2 dfl dfl)
[    0.186465] ACPI: INT_SRC_OVR (bus 0 bus_irq 9 global_irq 9 high level)
[    0.189472] ACPI: Using ACPI (MADT) for SMP configuration information
[    0.192469] smpboot: Allowing 2 CPUs, 0 hotplug CPUs
[    0.194716] PM: hibernation: Registered nosave memory: [mem 0x00000000-0x00000fff]
[    0.198100] PM: hibernation: Registered nosave memory: [mem 0x0009f000-0x0009ffff]
[    0.201477] PM: hibernation: Registered nosave memory: [mem 0x000a0000-0x000dffff]
[    0.204889] PM: hibernation: Registered nosave memory: [mem 0x000e0000-0x000fffff]
[    0.208490] PM: hibernation: Registered nosave memory: [mem 0x3fff0000-0x3fffefff]
[    0.211934] PM: hibernation: Registered nosave memory: [mem 0x3ffff000-0x3fffffff]
[    0.215387] PM: hibernation: Registered nosave memory: [mem 0x40000000-0xffffffff]
[    0.218769] [mem 0x40000000-0xffffffff] available for PCI devices
[    0.221576] Booting paravirtualized kernel on Hyper-V
[    0.224543] clocksource: refined-jiffies: mask: 0xffffffff max_cycles: 0xffffffff, max_idle_ns: 7645519600211568 ns
[    0.229369] setup_percpu: NR_CPUS:8192 nr_cpumask_bits:2 nr_cpu_ids:2 nr_node_ids:1
[    0.233026] percpu: Embedded 59 pages/cpu s204800 r8192 d28672 u1048576
[    0.236031] pcpu-alloc: s204800 r8192 d28672 u1048576 alloc=1*2097152
[    0.236033] pcpu-alloc: [0] 0 1 
[    0.236047] Hyper-V: PV spinlocks enabled
[    0.237866] PV qspinlock hash table entries: 256 (order: 0, 4096 bytes, linear)
[    0.241349] Built 1 zonelists, mobility grouping on.  Total pages: 2064112
[    0.244814] Policy zone: Normal
[    0.246285] Kernel command line: BOOT_IMAGE=/boot/vmlinuz-5.15.0-1041-azure root=PARTUUID=886ad3da-e4ec-442e-b223-03e615c2b78d ro console=tty1 console=ttyS0 earlyprintk=ttyS0 panic=-1
[    0.254092] Unknown kernel command line parameters "BOOT_IMAGE=/boot/vmlinuz-5.15.0-1041-azure", will be passed to user space.
[    0.260037] Dentry cache hash table entries: 1048576 (order: 11, 8388608 bytes, linear)
[    0.263898] Inode-cache hash table entries: 524288 (order: 10, 4194304 bytes, linear)
[    0.267687] mem auto-init: stack:off, heap alloc:on, heap free:off
[    0.284815] Memory: 8121268K/8388152K available (16392K kernel code, 4292K rwdata, 10400K rodata, 2976K init, 17148K bss, 266624K reserved, 0K cma-reserved)
[    0.293013] SLUB: HWalign=64, Order=0-3, MinObjects=0, CPUs=2, Nodes=1
[    0.296276] ftrace: allocating 48822 entries in 191 pages
[    0.318644] ftrace: allocated 191 pages with 7 groups
[    0.321283] rcu: Hierarchical RCU implementation.
[    0.323407] rcu:     RCU restricting CPUs from NR_CPUS=8192 to nr_cpu_ids=2.
[    0.326477]  Rude variant of Tasks RCU enabled.
[    0.328742]  Tracing variant of Tasks RCU enabled.
[    0.330944] rcu: RCU calculated value of scheduler-enlistment delay is 25 jiffies.
[    0.334300] rcu: Adjusting geometry for rcu_fanout_leaf=16, nr_cpu_ids=2
[    0.341106] NR_IRQS: 524544, nr_irqs: 440, preallocated irqs: 16
[    0.344505] random: crng init done
[    0.349740] Console: colour VGA+ 80x25
[    0.404299] printk: console [tty1] enabled
[    0.406724] printk: console [ttyS0] enabled
[    0.410869] printk: bootconsole [earlyser0] disabled
[    0.415908] ACPI: Core revision 20210730
[    0.418238] APIC: Switch to symmetric I/O mode setup
[    0.421210] Hyper-V: Using IPI hypercalls
[    0.423523] Hyper-V: Using enlightened APIC (xapic mode)
[    0.435325] ..TIMER: vector=0x30 apic1=0 pin1=2 apic2=-1 pin2=-1
[    0.441624] clocksource: tsc-early: mask: 0xffffffffffffffff max_cycles: 0x233fdd7d99c, max_idle_ns: 440795312688 ns
[    0.446839] Calibrating delay loop (skipped), value calculated using timer frequency.. 4890.86 BogoMIPS (lpj=9781728)
[    0.450838] pid_max: default: 32768 minimum: 301
[    0.453381] LSM: Security Framework initializing
[    0.454845] landlock: Up and running.
[    0.457025] Yama: becoming mindful.
[    0.458858] AppArmor: AppArmor initialized
[    0.461337] Mount-cache hash table entries: 16384 (order: 5, 131072 bytes, linear)
[    0.462843] Mountpoint-cache hash table entries: 16384 (order: 5, 131072 bytes, linear)
[    0.472251] x86/cpu: User Mode Instruction Prevention (UMIP) activated
[    0.474853] Last level iTLB entries: 4KB 512, 2MB 512, 4MB 256
[    0.478028] Last level dTLB entries: 4KB 2048, 2MB 2048, 4MB 1024, 1GB 0
[    0.478838] Spectre V1 : Mitigation: usercopy/swapgs barriers and __user pointer sanitization
[    0.482836] Spectre V2 : Mitigation: Retpolines
[    0.486835] Spectre V2 : Spectre v2 / SpectreRSB mitigation: Filling RSB on context switch
[    0.490835] Spectre V2 : Spectre v2 / SpectreRSB : Filling RSB on VMEXIT
[    0.494836] Speculative Store Bypass: Vulnerable
[    0.522228] Freeing SMP alternatives memory: 44K
[    0.523017] smpboot: CPU0: AMD EPYC 7763 64-Core Processor (family: 0x19, model: 0x1, stepping: 0x1)
[    0.526932] Performance Events: PMU not available due to virtualization, using software events only.
[    0.530860] rcu: Hierarchical SRCU implementation.
[    0.533725] NMI watchdog: Perf NMI watchdog permanently disabled
[    0.534878] smp: Bringing up secondary CPUs ...
[    0.537489] x86: Booting SMP configuration:
[    0.538839] .... node  #0, CPUs:      #1
[    0.539266] smp: Brought up 1 node, 2 CPUs
[    0.542839] smpboot: Max logical packages: 1
[    0.545174] smpboot: Total of 2 processors activated (9781.72 BogoMIPS)
[    0.547095] devtmpfs: initialized
[    0.547095] x86/mm: Memory block size: 128MB
[    0.550861] ACPI: PM: Registering ACPI NVS region [mem 0x3ffff000-0x3fffffff] (4096 bytes)
[    0.554871] clocksource: jiffies: mask: 0xffffffff max_cycles: 0xffffffff, max_idle_ns: 7645041785100000 ns
[    0.558841] futex hash table entries: 512 (order: 3, 32768 bytes, linear)
[    0.562440] pinctrl core: initialized pinctrl subsystem
[    0.563349] PM: RTC time: 22:05:13, date: 2023-09-06
[    0.566113] NET: Registered PF_NETLINK/PF_ROUTE protocol family
[    0.566948] DMA: preallocated 1024 KiB GFP_KERNEL pool for atomic allocations
[    0.570628] DMA: preallocated 1024 KiB GFP_KERNEL|GFP_DMA pool for atomic allocations
[    0.570889] DMA: preallocated 1024 KiB GFP_KERNEL|GFP_DMA32 pool for atomic allocations
[    0.574841] audit: initializing netlink subsys (disabled)
[    0.578151] audit: type=2000 audit(1694037913.132:1): state=initialized audit_enabled=0 res=1
[    0.578151] thermal_sys: Registered thermal governor 'fair_share'
[    0.578839] thermal_sys: Registered thermal governor 'bang_bang'
[    0.582211] thermal_sys: Registered thermal governor 'step_wise'
[    0.582837] thermal_sys: Registered thermal governor 'user_space'
[    0.585920] thermal_sys: Registered thermal governor 'power_allocator'
[    0.590842] EISA bus registered
[    0.594852] cpuidle: using governor ladder
[    0.598842] cpuidle: using governor menu
[    0.605669] ACPI: bus type PCI registered
[    0.606838] acpiphp: ACPI Hot Plug PCI Controller Driver version: 0.5
[    0.610747] PCI: Using configuration type 1 for base access
[    0.610837] PCI: Using configuration type 1 for extended access
[    0.615357] kprobes: kprobe jump-optimization is enabled. All kprobes are optimized if possible.
[    0.618858] HugeTLB registered 1.00 GiB page size, pre-allocated 0 pages
[    0.622286] HugeTLB registered 2.00 MiB page size, pre-allocated 0 pages
[    0.622890] ACPI: Added _OSI(Module Device)
[    0.625236] ACPI: Added _OSI(Processor Device)
[    0.626838] ACPI: Added _OSI(3.0 _SCP Extensions)
[    0.629411] ACPI: Added _OSI(Processor Aggregator Device)
[    0.634838] ACPI: Added _OSI(Linux-Dell-Video)
[    0.637260] ACPI: Added _OSI(Linux-Lenovo-NV-HDMI-Audio)
[    0.638840] ACPI: Added _OSI(Linux-HPI-Hybrid-Graphics)
[    0.643323] ACPI: 1 ACPI AML tables successfully acquired and loaded
[    0.648319] ACPI: Interpreter enabled
[    0.649174] ACPI: PM: (supports S0 S5)
[    0.650842] ACPI: Using IOAPIC for interrupt routing
[    0.653502] PCI: Using host bridge windows from ACPI; if necessary, use "pci=nocrs" and report a bug
[    0.658851] PCI: Using E820 reservations for host bridge windows
[    0.662339] ACPI: Enabled 1 GPEs in block 00 to 0F
[    0.681123] ACPI: PCI Root Bridge [PCI0] (domain 0000 [bus 00-ff])
[    0.682841] acpi PNP0A03:00: _OSC: OS supports [ExtendedConfig ASPM ClockPM Segments MSI EDR HPX-Type3]
[    0.686962] PCI host bridge to bus 0000:00
[    0.689479] pci_bus 0000:00: root bus resource [bus 00-ff]
[    0.694837] pci_bus 0000:00: root bus resource [io  0x0000-0x0cf7 window]
[    0.698628] pci_bus 0000:00: root bus resource [io  0x0d00-0xffff window]
[    0.702837] pci_bus 0000:00: root bus resource [mem 0x000a0000-0x000bffff window]
[    0.706662] pci_bus 0000:00: root bus resource [mem 0x40000000-0xfffbffff window]
[    0.710837] pci_bus 0000:00: root bus resource [mem 0xfc0000000-0xfffffffff window]
[    0.715457] pci 0000:00:00.0: [8086:7192] type 00 class 0x060000
[    0.722433] pci 0000:00:07.0: [8086:7110] type 00 class 0x060100
[    0.729375] pci 0000:00:07.1: [8086:7111] type 00 class 0x010180
[    0.732986] pci 0000:00:07.1: reg 0x20: [io  0xffa0-0xffaf]
[    0.739554] pci 0000:00:07.1: legacy IDE quirk: reg 0x10: [io  0x01f0-0x01f7]
[    0.742837] pci 0000:00:07.1: legacy IDE quirk: reg 0x14: [io  0x03f6]
[    0.746111] pci 0000:00:07.1: legacy IDE quirk: reg 0x18: [io  0x0170-0x0177]
[    0.750837] pci 0000:00:07.1: legacy IDE quirk: reg 0x1c: [io  0x0376]
[    0.755075] * Found PM-Timer Bug on the chipset. Due to workarounds for a bug,
               * this clock source is slow. Consider trying other clock sources
[    0.758837] pci 0000:00:07.3: [8086:7113] type 00 class 0x068000
[    0.764233] pci 0000:00:07.3: quirk: [io  0x0400-0x043f] claimed by PIIX4 ACPI
[    0.771911] pci 0000:00:08.0: [1414:5353] type 00 class 0x030000
[    0.775347] pci 0000:00:08.0: reg 0x10: [mem 0xf8000000-0xfbffffff]
[    0.780146] pci 0000:00:08.0: Video device with shadowed ROM at [mem 0x000c0000-0x000dffff]
[    0.803425] ACPI: PCI: Interrupt link LNKA configured for IRQ 11
[    0.806826] ACPI: PCI: Interrupt link LNKB configured for IRQ 0
[    0.806837] ACPI: PCI: Interrupt link LNKB disabled
[    0.809851] ACPI: PCI: Interrupt link LNKC configured for IRQ 0
[    0.814837] ACPI: PCI: Interrupt link LNKC disabled
[    0.817796] ACPI: PCI: Interrupt link LNKD configured for IRQ 0
[    0.822837] ACPI: PCI: Interrupt link LNKD disabled
[    0.825712] iommu: Default domain type: Translated 
[    0.826838] iommu: DMA domain TLB invalidation policy: lazy mode 
[    0.830290] SCSI subsystem initialized
[    0.830852] libata version 3.00 loaded.
[    0.830878] pci 0000:00:08.0: vgaarb: setting as boot VGA device
[    0.834067] pci 0000:00:08.0: vgaarb: VGA device added: decodes=io+mem,owns=io+mem,locks=none
[    0.834844] pci 0000:00:08.0: vgaarb: bridge control possible
[    0.837867] vgaarb: loaded
[    0.842851] ACPI: bus type USB registered
[    0.845239] usbcore: registered new interface driver usbfs
[    0.846843] usbcore: registered new interface driver hub
[    0.849662] usbcore: registered new device driver usb
[    0.850846] pps_core: LinuxPPS API ver. 1 registered
[    0.853502] pps_core: Software ver. 5.3.6 - Copyright 2005-2007 Rodolfo Giometti <giometti@linux.it>
[    0.858838] PTP clock support registered
[    0.862853] EDAC MC: Ver: 3.0.0
[    0.865112] hv_vmbus: Vmbus version:5.3
[    0.867015] NetLabel: Initializing
[    0.870838] NetLabel:  domain hash size = 128
[    0.873221] NetLabel:  protocols = UNLABELED CIPSOv4 CALIPSO
[    0.874849] NetLabel:  unlabeled traffic allowed by default
[    0.878847] PCI: Using ACPI for IRQ routing
[    0.882838] PCI: pci_cache_line_size set to 64 bytes
[    0.883198] e820: reserve RAM buffer [mem 0x0009fc00-0x0009ffff]
[    0.883200] e820: reserve RAM buffer [mem 0x3fff0000-0x3fffffff]
[    0.883207] clocksource: Switched to clocksource tsc-early
[    0.892628] VFS: Disk quotas dquot_6.6.0
[    0.894967] VFS: Dquot-cache hash table entries: 512 (order 0, 4096 bytes)
[    0.898658] AppArmor: AppArmor Filesystem Enabled
[    0.901202] pnp: PnP ACPI init
[    0.903678] pnp 00:03: [dma 0 disabled]
[    0.904221] pnp 00:04: [dma 0 disabled]
[    0.904782] pnp 00:05: [dma 2]
[    0.904827] system 00:06: [io  0x01e0-0x01ef] has been reserved
[    0.910722] system 00:06: [io  0x0160-0x016f] has been reserved
[    0.914386] system 00:06: [io  0x0278-0x027f] has been reserved
[    0.917749] system 00:06: [io  0x0378-0x037f] has been reserved
[    0.921202] system 00:06: [io  0x0678-0x067f] has been reserved
[    0.924688] system 00:06: [io  0x0778-0x077f] has been reserved
[    0.927950] system 00:06: [io  0x04d0-0x04d1] has been reserved
[    0.931356] system 00:07: [io  0x0400-0x043f] has been reserved
[    0.934534] system 00:07: [io  0x0370-0x0371] has been reserved
[    0.937642] system 00:07: [io  0x0440-0x044f] has been reserved
[    0.940973] system 00:07: [mem 0xfec00000-0xfec00fff] could not be reserved
[    0.944520] system 00:07: [mem 0xfee00000-0xfee00fff] has been reserved
[    0.948051] system 00:08: [mem 0x00000000-0x0009ffff] could not be reserved
[    0.951615] system 00:08: [mem 0x000c0000-0x000dffff] could not be reserved
[    0.955521] system 00:08: [mem 0x000e0000-0x000fffff] could not be reserved
[    0.959330] system 00:08: [mem 0x00100000-0x3fffffff] could not be reserved
[    0.963140] system 00:08: [mem 0xfffc0000-0xffffffff] has been reserved
[    0.966858] pnp: PnP ACPI: found 9 devices
[    0.975928] clocksource: acpi_pm: mask: 0xffffff max_cycles: 0xffffff, max_idle_ns: 2085701024 ns
[    0.980591] NET: Registered PF_INET protocol family
[    0.983368] IP idents hash table entries: 131072 (order: 8, 1048576 bytes, linear)
[    0.988099] tcp_listen_portaddr_hash hash table entries: 4096 (order: 4, 65536 bytes, linear)
[    0.992853] Table-perturb hash table entries: 65536 (order: 6, 262144 bytes, linear)
[    0.997162] TCP established hash table entries: 65536 (order: 7, 524288 bytes, linear)
[    1.001753] TCP bind hash table entries: 65536 (order: 8, 1048576 bytes, linear)
[    1.006120] TCP: Hash tables configured (established 65536 bind 65536)
[    1.009726] MPTCP token hash table entries: 8192 (order: 5, 196608 bytes, linear)
[    1.013714] UDP hash table entries: 4096 (order: 5, 131072 bytes, linear)
[    1.017516] UDP-Lite hash table entries: 4096 (order: 5, 131072 bytes, linear)
[    1.025239] NET: Registered PF_UNIX/PF_LOCAL protocol family
[    1.028311] NET: Registered PF_XDP protocol family
[    1.030983] pci_bus 0000:00: resource 4 [io  0x0000-0x0cf7 window]
[    1.034408] pci_bus 0000:00: resource 5 [io  0x0d00-0xffff window]
[    1.037830] pci_bus 0000:00: resource 6 [mem 0x000a0000-0x000bffff window]
[    1.041408] pci_bus 0000:00: resource 7 [mem 0x40000000-0xfffbffff window]
[    1.044999] pci_bus 0000:00: resource 8 [mem 0xfc0000000-0xfffffffff window]
[    1.048648] pci 0000:00:00.0: Limiting direct PCI/PCI transfers
[    1.052443] PCI: CLS 0 bytes, default 64
[    1.054876] PCI-DMA: Using software bounce buffering for IO (SWIOTLB)
[    1.058204] software IO TLB: mapped [mem 0x000000003bff0000-0x000000003fff0000] (64MB)
[    1.062588] Initialise system trusted keyrings
[    1.065028] Key type blacklist registered
[    1.067658] workingset: timestamp_bits=36 max_order=21 bucket_order=0
[    1.071748] zbud: loaded
[    1.073457] squashfs: version 4.0 (2009/01/31) Phillip Lougher
[    1.076597] fuse: init (API version 7.34)
[    1.078961] integrity: Platform Keyring initialized
[    1.084969] Key type asymmetric registered
[    1.087310] Asymmetric key parser 'x509' registered
[    1.089995] Block layer SCSI generic (bsg) driver version 0.4 loaded (major 244)
[    1.093940] io scheduler mq-deadline registered
[    1.097329] shpchp: Standard Hot Plug PCI Controller Driver version: 0.4
[    1.101311] hv_vmbus: registering driver hv_pci
[    1.103823] input: Power Button as /devices/LNXSYSTM:00/LNXPWRBN:00/input/input0
[    1.107611] ACPI: button: Power Button [PWRF]
[    1.110295] Serial: 8250/16550 driver, 32 ports, IRQ sharing enabled
[    1.139821] 00:03: ttyS0 at I/O 0x3f8 (irq = 4, base_baud = 115200) is a 16550A
[    1.169933] 00:04: ttyS1 at I/O 0x2f8 (irq = 3, base_baud = 115200) is a 16550A
[    1.175769] Linux agpgart interface v0.103
[    1.179351] loop: module loaded
[    1.182279] hv_vmbus: registering driver hv_storvsc
[    1.185249] ata_piix 0000:00:07.1: version 2.13
[    1.185595] ata_piix 0000:00:07.1: Hyper-V Virtual Machine detected, ATA device ignore set
[    1.185719] scsi host2: storvsc_host_t
[    1.192240] scsi host4: ata_piix
[    1.192615] scsi host1: storvsc_host_t
[    1.194638] scsi host5: ata_piix
[    1.197222] scsi 1:0:1:0: Direct-Access     Msft     Virtual Disk     1.0  PQ: 0 ANSI: 5
[    1.199168] ata1: PATA max UDMA/33 cmd 0x1f0 ctl 0x3f6 bmdma 0xffa0 irq 14
[    1.204102] scsi 1:0:1:0: Attached scsi generic sg0 type 0
[    1.207313] ata2: PATA max UDMA/33 cmd 0x170 ctl 0x376 bmdma 0xffa8 irq 15
[    1.210377] scsi host0: storvsc_host_t
[    1.217377] scsi host3: storvsc_host_t
[    1.217491] tun: Universal TUN/TAP device driver, 1.6
[    1.220291] scsi: waiting for bus probes to complete ...
[    1.222664] PPP generic driver version 2.4.2
[    1.228665] VFIO - User Level meta-driver version: 0.3
[    1.228846] sd 1:0:1:0: [sda] 94371840 512-byte logical blocks: (48.3 GB/45.0 GiB)
[    1.231860] i8042: PNP: PS/2 Controller [PNP0303:PS2K,PNP0f03:PS2M] at 0x60,0x64 irq 1,12
[    1.236032] sd 1:0:1:0: [sda] 4096-byte physical blocks
[    1.245742] sd 1:0:1:0: [sda] Write Protect is off
[    1.245894] serio: i8042 KBD port at 0x60,0x64 irq 1
[    1.248802] sd 1:0:1:0: [sda] Mode Sense: 0f 00 10 00
[    1.251572] serio: i8042 AUX port at 0x60,0x64 irq 12
[    1.251697] sd 1:0:1:0: [sda] Write cache: disabled, read cache: enabled, supports DPO and FUA
[    1.254427] mousedev: PS/2 mouse device common for all mice
[    1.263279] rtc_cmos 00:00: RTC can wake from S4
[    1.268612] rtc_cmos 00:00: registered as rtc0
[    1.271666] rtc_cmos 00:00: setting system clock to 2023-09-06T22:05:14 UTC (1694037914)
[    1.276252] rtc_cmos 00:00: alarms up to one month, 114 bytes nvram
[    1.279712] device-mapper: core: CONFIG_IMA_DISABLE_HTABLE is disabled. Duplicate IMA measurements will not be recorded in the IMA log.
[    1.283226]  sda: sda1
[    1.285748] device-mapper: uevent: version 1.0.3
[    1.289828] device-mapper: ioctl: 4.45.0-ioctl (2021-03-22) initialised: dm-devel@redhat.com
[    1.294396] platform eisa.0: Probing EISA bus 0
[    1.296910] platform eisa.0: EISA: Cannot allocate resource for mainboard
[    1.300468] platform eisa.0: Cannot allocate resource for EISA slot 1
[    1.303785] platform eisa.0: Cannot allocate resource for EISA slot 2
[    1.307311] platform eisa.0: Cannot allocate resource for EISA slot 3
[    1.311288] platform eisa.0: Cannot allocate resource for EISA slot 4
[    1.311529] scsi 0:0:0:0: Direct-Access     Msft     Virtual Disk     1.0  PQ: 0 ANSI: 5
[    1.315028] platform eisa.0: Cannot allocate resource for EISA slot 5
[    1.320993] sd 0:0:0:0: Attached scsi generic sg1 type 0
[    1.324719] platform eisa.0: Cannot allocate resource for EISA slot 6
[    1.328082] sd 0:0:0:0: [sdb] 62916608 512-byte logical blocks: (32.2 GB/30.0 GiB)
[    1.331267] platform eisa.0: Cannot allocate resource for EISA slot 7
[    1.335122] sd 0:0:0:0: [sdb] 4096-byte physical blocks
[    1.335232] sd 0:0:0:0: [sdb] Write Protect is off
[    1.338668] platform eisa.0: Cannot allocate resource for EISA slot 8
[    1.341710] sd 0:0:0:0: [sdb] Mode Sense: 0f 00 10 00
[    1.344520] platform eisa.0: EISA: Detected 0 cards
[    1.348191] sd 0:0:0:0: [sdb] Write cache: disabled, read cache: enabled, supports DPO and FUA
[    1.350888] sd 1:0:1:0: [sda] Attached SCSI disk
[    1.355607] hv_utils: Registering HyperV Utility Driver
[    1.362519] hv_vmbus: registering driver hv_utils
[    1.365125] input: AT Translated Set 2 keyboard as /devices/platform/i8042/serio0/input/input1
[    1.366886] hv_vmbus: registering driver hv_balloon
[    1.369888] hv_utils: Shutdown IC version 3.2
[    1.372461] drop_monitor: Initializing network drop monitor service
[    1.375302] hv_utils: Heartbeat IC version 3.0
[    1.379004] NET: Registered PF_INET6 protocol family
[    1.381542] hv_utils: TimeSync IC version 4.0
[    1.387335] Segment Routing with IPv6
[    1.388828] hv_balloon: Using Dynamic Memory protocol version 2.0
[    1.389975] In-situ OAM (IOAM) with IPv6
[    1.398867] NET: Registered PF_PACKET protocol family
[    1.402098] Key type dns_resolver registered
[    1.507789] IPI shorthand broadcast: enabled
[    1.510586] sched_clock: Marking stable (1409358065, 98346400)->(1545647700, -37943235)
[    1.536740] registered taskstats version 1
[    1.540320]  sdb: sdb1 sdb14 sdb15
[    1.597170] Loading compiled-in X.509 certificates
[    1.597567] ata2.00: ATAPI: Virtual CD, , max MWDMA2
[    1.600488] Loaded X.509 cert 'Build time autogenerated kernel key: 2927855d383d7592077baa4517870d3e639d7551'
[    1.606140] scsi 5:0:0:0: CD-ROM            Msft     Virtual CD/ROM   1.0  PQ: 0 ANSI: 5
[    1.608805] Loaded X.509 cert 'Canonical Ltd. Live Patch Signing: 14df34d1a87cf37625abec039ef2bf521249b969'
[    1.616364] sr 5:0:0:0: [sr0] scsi3-mmc drive: 0x/0x tray
[    1.618718] sd 0:0:0:0: [sdb] Attached SCSI disk
[    1.621566] cdrom: Uniform CD-ROM driver Revision: 3.20
[    1.624379] Loaded X.509 cert 'Canonical Ltd. Kernel Module Signing: 88f752e560a1e0737e31163a466ad7b70a850c19'
[    1.632841] blacklist: Loading compiled-in revocation X.509 certificates
[    1.636278] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing: 61482aa2830d0ab2ad5af10b7250da9033ddcef0'
[    1.641135] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (2017): 242ade75ac4a15e50d50c84b0d45ff3eae707a03'
[    1.646517] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (ESM 2018): 365188c1d374d6b07c3c8f240f8ef722433d6a8b'
[    1.652035] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (2019): c0746fd6c5da3ae827864651ad66ae47fe24b3e8'
[    1.657199] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (2021 v1): a8d54bbb3825cfb94fa13c9f8a594a195c107b8d'
[    1.662935] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (2021 v2): 4cf046892d6fd3c9a5b03f98d845f90851dc6a8c'
[    1.668506] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (2021 v3): 100437bb6de6e469b581e61cd66bce3ef4ed53af'
[    1.673957] Loaded X.509 cert 'Canonical Ltd. Secure Boot Signing (Ubuntu Core 2019): c1d57b8f6b743f23ee41f4f7ee292f06eecadfb9'
[    1.679731] zswap: loaded using pool lzo/zbud
[    1.682363] Key type .fscrypt registered
[    1.684546] Key type fscrypt-provisioning registered
[    1.687556] Key type encrypted registered
[    1.689767] AppArmor: AppArmor sha1 policy hashing enabled
[    1.692715] ima: No TPM chip found, activating TPM-bypass!
[    1.696887] sr 5:0:0:0: Attached scsi CD-ROM sr0
[    1.697587] Loading compiled-in module X.509 certificates
[    1.697924] sr 5:0:0:0: Attached scsi generic sg2 type 5
[    1.700988] Loaded X.509 cert 'Build time autogenerated kernel key: 2927855d383d7592077baa4517870d3e639d7551'
[    1.708366] ima: Allocated hash algorithm: sha1
[    1.711150] ima: No architecture policies found
[    1.713772] evm: Initialising EVM extended attributes:
[    1.716712] evm: security.selinux
[    1.718675] evm: security.SMACK64
[    1.720630] evm: security.SMACK64EXEC
[    1.722788] evm: security.SMACK64TRANSMUTE
[    1.725236] evm: security.SMACK64MMAP
[    1.727505] evm: security.apparmor
[    1.729447] evm: security.ima
[    1.731212] evm: security.capability
[    1.733244] evm: HMAC attrs: 0x1
[    1.735332] PM:   Magic number: 7:317:97
[    1.737675] RAS: Correctable Errors collector initialized.
[    1.741780] md: Waiting for all devices to be available before autodetect
[    1.745411] md: If you don't use raid, use raid=noautodetect
[    1.748682] md: Autodetecting RAID arrays.
[    1.751072] md: autorun ...
[    1.752979] md: ... autorun DONE.
[    1.756035] EXT4-fs (sdb1): mounted filesystem with ordered data mode. Opts: (null). Quota mode: none.
[    1.761294] VFS: Mounted root (ext4 filesystem) readonly on device 8:17.
[    1.765232] devtmpfs: mounted
[    1.767677] Freeing unused decrypted memory: 2036K
[    1.770984] Freeing unused kernel image (initmem) memory: 2976K
[    1.782844] Write protecting the kernel read-only data: 30720k
[    1.786469] Freeing unused kernel image (text/rodata gap) memory: 2036K
[    1.790654] Freeing unused kernel image (rodata/data gap) memory: 1888K
[    1.825562] x86/mm: Checked W+X mappings: passed, no W+X pages found.
[    1.829010] Run /sbin/init as init process
[    1.831300]   with arguments:
[    1.831301]     /sbin/init
[    1.831301]   with environment:
[    1.831302]     HOME=/
[    1.831302]     TERM=linux
[    1.831303]     BOOT_IMAGE=/boot/vmlinuz-5.15.0-1041-azure
[    1.892290] systemd[1]: Inserted module 'autofs4'
[    1.900995] systemd[1]: systemd 249.11-0ubuntu3.9 running in system mode (+PAM +AUDIT +SELINUX +APPARMOR +IMA +SMACK +SECCOMP +GCRYPT +GNUTLS +OPENSSL +ACL +BLKID +CURL +ELFUTILS +FIDO2 +IDN2 -IDN +IPTC +KMOD +LIBCRYPTSETUP +LIBFDISK +PCRE2 -PWQUALITY -P11KIT -QRENCODE +BZIP2 +LZ4 +XZ +ZLIB +ZSTD -XKBCOMMON +UTMP +SYSVINIT default-hierarchy=unified)
[    1.934906] systemd[1]: Detected virtualization microsoft.
[    1.937979] systemd[1]: Detected architecture x86-64.
[    1.957600] systemd[1]: Hostname set to <localhost.localdomain>.
[    2.074858] tsc: Refined TSC clocksource calibration: 2445.435 MHz
[    2.078400] clocksource: tsc: mask: 0xffffffffffffffff max_cycles: 0x233fe0862e1, max_idle_ns: 440795313989 ns
[    2.083675] clocksource: Switched to clocksource tsc
[    2.249535] systemd[1]: Queued start job for default target Graphical Interface.
[    2.253570] systemd[1]: Unnecessary job was removed for /sys/devices/virtual/misc/vmbus!hv_fcopy.
[    2.259799] systemd[1]: Unnecessary job was removed for /sys/devices/virtual/misc/vmbus!hv_vss.
[    2.279593] systemd[1]: Created slice Slice /system/modprobe.
[    2.285105] systemd[1]: Created slice Slice /system/serial-getty.
[    2.291139] systemd[1]: Created slice Slice /system/systemd-fsck.
[    2.296742] systemd[1]: Created slice User and Session Slice.
[    2.301972] systemd[1]: Started Forward Password Requests to Wall Directory Watch.
[    2.308666] systemd[1]: Set up automount Arbitrary Executable File Formats File System Automount Point.
[    2.316204] systemd[1]: Reached target Slice Units.
[    2.320822] systemd[1]: Reached target Mounting snaps.
[    2.325460] systemd[1]: Reached target Swaps.
[    2.329549] systemd[1]: Reached target System Time Set.
[    2.334450] systemd[1]: Reached target Local Verity Protected Volumes.
[    2.340827] systemd[1]: Listening on Device-mapper event daemon FIFOs.
[    2.347160] systemd[1]: Listening on LVM2 poll daemon socket.
[    2.352772] systemd[1]: Listening on multipathd control socket.
[    2.358600] systemd[1]: Listening on Syslog Socket.
[    2.363565] systemd[1]: Listening on fsck to fsckd communication Socket.
[    2.371868] systemd[1]: Listening on initctl Compatibility Named Pipe.
[    2.378338] systemd[1]: Listening on Journal Audit Socket.
[    2.383936] systemd[1]: Listening on Journal Socket (/dev/log).
[    2.389830] systemd[1]: Listening on Journal Socket.
[    2.394992] systemd[1]: Listening on Network Service Netlink Socket.
[    2.401290] systemd[1]: Listening on udev Control Socket.
[    2.406750] systemd[1]: Listening on udev Kernel Socket.
[    2.427409] systemd[1]: Mounting Huge Pages File System...
[    2.433264] systemd[1]: Mounting POSIX Message Queue File System...
[    2.439084] systemd[1]: Mounting Kernel Debug File System...
[    2.444570] systemd[1]: Mounting Kernel Trace File System...
[    2.451015] systemd[1]: Starting Journal Service...
[    2.456215] systemd[1]: Starting Set the console keyboard layout...
[    2.462483] systemd[1]: Starting Create List of Static Device Nodes...
[    2.470288] systemd[1]: Starting Monitoring of LVM2 mirrors, snapshots etc. using dmeventd or progress polling...
[    2.485394] systemd[1]: Condition check resulted in LXD - agent being skipped.
[    2.490641] systemd[1]: Starting Load Kernel Module chromeos_pstore...
[    2.518983] systemd[1]: Starting Load Kernel Module configfs...
[    2.524546] systemd[1]: Starting Load Kernel Module drm...
[    2.530222] systemd[1]: Starting Load Kernel Module efi_pstore...
[    2.537381] systemd[1]: Starting Load Kernel Module fuse...
[    2.544309] systemd[1]: Starting Load Kernel Module pstore_blk...
[    2.550026] systemd[1]: Starting Load Kernel Module pstore_zone...
[    2.555771] systemd[1]: Starting Load Kernel Module ramoops...
[    2.560770] systemd[1]: Condition check resulted in OpenVSwitch configuration for cleanup being skipped.
[    2.566119] systemd[1]: Started Nameserver information manager.
[    2.572436] systemd[1]: Starting File System Check on Root Device...
[    2.579247] systemd[1]: Starting Load Kernel Modules...
[    2.584517] systemd[1]: Starting Coldplug All udev Devices...
[    2.591144] systemd[1]: Started Journal Service.
[    2.687961] EXT4-fs (sdb1): re-mounted. Opts: discard,errors=remount-ro. Quota mode: none.
[    2.716989] systemd-journald[184]: Received client request to flush runtime journal.
[    2.717334] alua: device handler registered
[    2.718292] emc: device handler registered
[    2.719413] rdac: device handler registered
[    2.908453] hv_vmbus: registering driver hv_netvsc
[    2.911637] hv_vmbus: registering driver hyperv_keyboard
[    2.911933] input: AT Translated Set 2 keyboard as /devices/LNXSYSTM:00/LNXSYBUS:00/PNP0A03:00/device:07/VMBUS:01/d34b2567-b9b6-42b9-8778-0a4ec0b955bf/serio2/input/input3
[    2.912807] hid: raw HID events driver (C) Jiri Kosina
[    2.925094] hv_vmbus: registering driver hid_hyperv
[    2.927304] input: Microsoft Vmbus HID-compliant Mouse as /devices/0006:045E:0621.0001/input/input4
[    2.927352] hid 0006:045E:0621.0001: input: VIRTUAL HID v0.01 Mouse [Microsoft Vmbus HID-compliant Mouse] on 
[    2.986890] cryptd: max_cpu_qlen set to 1000
[    2.993111] AVX2 version of gcm_enc/dec engaged.
[    2.993161] AES CTR mode by8 optimization enabled
[    3.079781] hv_vmbus: registering driver hyperv_drm
[    3.080621] hyperv_drm 5620e0c7-8062-4dce-aeb7-520c7ef76171: [drm] Synthvid Version major 3, minor 5
[    3.080690] hyperv_drm 0000:00:08.0: vgaarb: deactivate vga console
[    3.080784] Console: switching to colour dummy device 80x25
[    3.081020] [drm] Initialized hyperv_drm 1.0.0 2020 for 5620e0c7-8062-4dce-aeb7-520c7ef76171 on minor 0
[    3.247643] Console: switching to colour frame buffer device 128x48
[    3.330163] hv_utils: KVP IC version 4.0
[    3.343501] hyperv_drm 5620e0c7-8062-4dce-aeb7-520c7ef76171: [drm] fb0: hyperv_drmdrmfb frame buffer device
[    3.606497] kvm: Nested Virtualization enabled
[    3.606501] SVM: kvm: Nested Paging enabled
[    3.606502] SVM: kvm: Hyper-V enlightened NPT TLB flush enabled
[    3.606502] SVM: kvm: Hyper-V Direct TLB Flush enabled
[    3.606604] SVM: Virtual VMLOAD VMSAVE supported
[    4.123526] loop0: detected capacity change from 0 to 129944
[    4.148002] loop1: detected capacity change from 0 to 229272
[    4.299822] loop2: detected capacity change from 0 to 109072
[    4.446174] audit: type=1400 audit(1694037918.317:2): apparmor="STATUS" operation="profile_load" profile="unconfined" name="lsb_release" pid=438 comm="apparmor_parser"
[    4.452561] audit: type=1400 audit(1694037918.325:3): apparmor="STATUS" operation="profile_load" profile="unconfined" name="nvidia_modprobe" pid=439 comm="apparmor_parser"
[    4.452565] audit: type=1400 audit(1694037918.325:4): apparmor="STATUS" operation="profile_load" profile="unconfined" name="nvidia_modprobe//kmod" pid=439 comm="apparmor_parser"
[    4.457677] audit: type=1400 audit(1694037918.329:5): apparmor="STATUS" operation="profile_load" profile="unconfined" name="/usr/bin/man" pid=442 comm="apparmor_parser"
[    4.457681] audit: type=1400 audit(1694037918.329:6): apparmor="STATUS" operation="profile_load" profile="unconfined" name="man_filter" pid=442 comm="apparmor_parser"
[    4.457684] audit: type=1400 audit(1694037918.329:7): apparmor="STATUS" operation="profile_load" profile="unconfined" name="man_groff" pid=442 comm="apparmor_parser"
[    4.474385] audit: type=1400 audit(1694037918.345:8): apparmor="STATUS" operation="profile_load" profile="unconfined" name="tcpdump" pid=443 comm="apparmor_parser"
[    4.475840] audit: type=1400 audit(1694037918.345:9): apparmor="STATUS" operation="profile_load" profile="unconfined" name="/usr/lib/NetworkManager/nm-dhcp-client.action" pid=440 comm="apparmor_parser"
[    4.475843] audit: type=1400 audit(1694037918.345:10): apparmor="STATUS" operation="profile_load" profile="unconfined" name="/usr/lib/NetworkManager/nm-dhcp-helper" pid=440 comm="apparmor_parser"
[    5.002870] UDF-fs: INFO Mounting volume 'UDF Volume', timestamp 2023/09/07 00:00 (1000)
[    5.030630] IPv6: ADDRCONF(NETDEV_CHANGE): eth0: link becomes ready
[   49.478701] hv_balloon: Max. dynamic memory size: 8192 MB
[ 4127.908250] sr 5:0:0:0: [sr0] tag#0 FAILED Result: hostbyte=DID_OK driverbyte=DRIVER_OK cmd_age=0s
[ 4127.908255] sr 5:0:0:0: [sr0] tag#0 Sense Key : Not Ready [current] 
[ 4127.908257] sr 5:0:0:0: [sr0] tag#0 Add. Sense: Medium not present
[ 4127.908259] sr 5:0:0:0: [sr0] tag#0 CDB: Read(10) 28 00 00 00 00 02 00 00 02 00
[ 4127.908260] blk_update_request: I/O error, dev sr0, sector 8 op 0x0:(READ) flags 0x80700 phys_seg 1 prio class 0
[ 4127.944113] sr 5:0:0:0: [sr0] tag#0 FAILED Result: hostbyte=DID_OK driverbyte=DRIVER_OK cmd_age=0s
[ 4127.944116] sr 5:0:0:0: [sr0] tag#0 Sense Key : Not Ready [current] 
[ 4127.944118] sr 5:0:0:0: [sr0] tag#0 Add. Sense: Medium not present
[ 4127.944119] sr 5:0:0:0: [sr0] tag#0 CDB: Read(10) 28 00 00 00 00 02 00 00 02 00
[ 4127.944120] blk_update_request: I/O error, dev sr0, sector 8 op 0x0:(READ) flags 0x0 phys_seg 1 prio class 0
[ 4127.948635] Buffer I/O error on dev sr0, logical block 1, async page read
[ 4128.111803]  sda: sda1
[ 4129.308585] EXT4-fs (sda1): mounted filesystem with ordered data mode. Opts: (null). Quota mode: none.
[ 4135.678538] bpfilter: Loaded bpfilter_umh pid 1064
[ 4135.678789] Started bpfilter
[ 4137.111373] loop3: detected capacity change from 0 to 8
[ 4138.180222] bridge: filtering via arp/ip/ip6tables is no longer available by default. Update your scripts to load br_netfilter if you need this.
[ 4138.186774] Bridge firewalling registered
[ 4138.413460] Initializing XFRM netlink socket
[ 4169.419125] FS-Cache: Loaded
[ 4169.486559] FS-Cache: Netfs 'cifs' registered for caching
[ 4169.494753] Key type cifs.spnego registered
[ 4169.494767] Key type cifs.idmap registered
[ 4347.234765] CIFS: No dialect specified on mount. Default has changed to a more secure dialect, SMB2.1 or later (e.g. SMB3.1.1), from CIFS (SMB1). To use the less secure SMB1 dialect to access old servers which do not support SMB3.1.1 (or even SMB3 or SMB2.1) specify vers=1.0 on mount.
[ 4347.234769] CIFS: Attempting to mount \\vsoce18189e0c98164378805.z11.file.storage.azure.net\cloudenvdata
[ 4347.380698] loop3: detected capacity change from 0 to 67108864
[ 4347.496669] EXT4-fs (loop3): mounted filesystem with ordered data mode. Opts: (null). Quota mode: none.
[ 4347.516051] loop4: detected capacity change from 0 to 1024000
[ 4347.627439] blk_update_request: operation not supported error, dev loop3, sector 46137600 op 0x9:(WRITE_ZEROES) flags 0x800 phys_seg 0 prio class 0
[ 4347.661503] EXT4-fs (loop4): mounted filesystem with ordered data mode. Opts: (null). Quota mode: none.
[ 4347.661514] ext4 filesystem being mounted at /var/log/codespaces/backup supports timestamps until 2038 (0x7fffffff)
[ 4349.023432] blk_update_request: operation not supported error, dev loop3, sector 46141696 op 0x9:(WRITE_ZEROES) flags 0x800 phys_seg 0 prio class 0
[ 4350.367437] blk_update_request: operation not supported error, dev loop3, sector 46145792 op 0x9:(WRITE_ZEROES) flags 0x800 phys_seg 0 prio class 0
[ 4351.743466] blk_update_request: operation not supported error, dev loop3, sector 46149888 op 0x9:(WRITE_ZEROES) flags 0x800 phys_seg 0 prio class 0
[ 4353.087449] blk_update_request: operation not supported error, dev loop3, sector 46153984 op 0x9:(WRITE_ZEROES) flags 0x800 phys_seg 0 prio class 0

