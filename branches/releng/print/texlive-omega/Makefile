# New ports collection makefile for:	texlive-omega
# Date created:		26/01/2009 16:10:39
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	omega
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A wide-character-set extension of TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.omega.cnf:${PORTSDIR}/print/texlive-bin-omega

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
