# New ports collection makefile for:	texlive-vpe
# Date created:		26/01/2009 16:09:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	vpe
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Source specials for PDF output.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
