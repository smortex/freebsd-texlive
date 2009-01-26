# New ports collection makefile for:	texlive-bin-texlive
# Date created:		26/01/2009 16:02:49
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-texlive
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	executables and files maintained as part of TeX Live

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
