# New ports collection makefile for:	texlive-phyzzx
# Date created:		26/01/2009 16:04:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	phyzzx
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A TeX format for physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.phyzzx.cnf:${PORTSDIR}/print/texlive-bin-phyzzx

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
