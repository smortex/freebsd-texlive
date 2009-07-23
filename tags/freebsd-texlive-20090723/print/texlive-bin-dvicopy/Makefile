# New ports collection makefile for:	texlive-bin-dvicopy
# Date created:		26/01/2009 16:03:41
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvicopy
PORTREVISION=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Copy DVI files, flattening VFs.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
