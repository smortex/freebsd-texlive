
TARGET=		TLPort.exe
CSFILES=	TLPort.cs IPackage.cs Package.cs PackageCollection.cs ndesk-options-0.2.1/src/NDesk.Options/NDesk.Options/Options.cs

TLPOBJDIR?=	/home/romain/Projects/freebsd-texlive/ftp
PORTSDIR?=	/home/romain/Projects/freebsd-texlive

MCS=		gmcs
MCS_FLAGS=

MONO=		mono
MONO_FLAGS=

all: ${TARGET}

run: ${TARGET}
	${MONO} ${MONO_ARGS} ${TARGET} ${TLPOBJDIR} ${PORTSDIR}

ndesk-options-0.2.1/src/NDesk.Options/NDesk.Options/Options.cs: ndesk-options-0.2.1.tar.gz
	tar zxf ndesk-options-0.2.1.tar.gz ${.TARGET}

ndesk-options-0.2.1.tar.gz:
	fetch http://www.ndesk.org/archive/ndesk-options/ndesk-options-0.2.1.tar.gz

${TARGET}: ${CSFILES}
	${MCS} ${MCS_FLAGS} -out:${.TARGET} ${CSFILES}

NDesk.Options.dll:
	cp `pkg-config --variable=Libraries ndesk-options` ${.TARGET}

clean:
	rm -f ${TARGET}
