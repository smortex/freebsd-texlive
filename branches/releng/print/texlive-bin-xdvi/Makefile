# New ports collection makefile for:	texlive-bin-xdvi
# Date created:		26/01/2009 16:02:50
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-xdvi
PORTREVISION=	11
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A DVI previewer for the X Window System.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
