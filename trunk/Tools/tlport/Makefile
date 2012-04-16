XBUILD=	/usr/local/bin/xbuild

all: ${.CURDIR}/bin/Debug/tlport.exe ${.CURDIR}/bin/Debug/NDesk.Options.dll

${.CURDIR}/bin/Debug/tlport.exe:
	cd ${.CURDIR} && ${XBUILD}

${.CURDIR}/bin/Debug/NDesk.Options.dll:
	cp `pkg-config --variable=Libraries ndesk-options` ${.TARGET}

#clean:
#	cd ${.CURDIR} && ${XBUILD} /target:clean

CLEANDIRS=	${.CURDIR}/bin ${.CURDIR}/obj

.include <bsd.obj.mk>
