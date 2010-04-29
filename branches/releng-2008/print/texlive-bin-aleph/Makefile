# New ports collection makefile for:	texlive-bin-aleph
# Date created:		26/01/2009 16:03:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-aleph
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Extended TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.omega.cnf:${PORTSDIR}/print/texlive-bin-omega \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
