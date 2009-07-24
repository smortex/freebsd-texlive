# New ports collection makefile for:	texlive-bin-getafm
# Date created:		26/01/2009 16:11:19
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-getafm
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-getafm package

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
